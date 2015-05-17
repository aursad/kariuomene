using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Kariuomene.Common;
using System;
using Windows.ApplicationModel.Resources;
using Windows.Graphics.Display;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Hub Application template is documented at http://go.microsoft.com/fwlink/?LinkId=391641
using Kariuomene.DataModel;
using Kariuomene.Pages;
using Kariuomene.ViewModel;

namespace Kariuomene
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class HubPage : Page
    {
        private readonly NavigationHelper _navigationHelper;
        private readonly ObservableDictionary _defaultViewModel = new ObservableDictionary();
        private readonly ResourceLoader _resourceLoader = ResourceLoader.GetForCurrentView("Resources");
        private readonly CacheProvider _cacheProvider = new CacheProvider();
        private readonly StatusBar _statusBar = StatusBar.GetForCurrentView();

        public HubPage()
        {
            InitializeComponent();

            // Hub is only supported in Portrait orientation
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait;

            NavigationCacheMode = NavigationCacheMode.Required;

            _navigationHelper = new NavigationHelper(this);
            _navigationHelper.LoadState += NavigationHelper_LoadState;
            _navigationHelper.SaveState += NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return _navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return _defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private async void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            SetCountDown();

            var regionsDataModel = new RegionDataModel();
            var regions = await regionsDataModel.Regions;

            var departmentsDto = new DepartmentDataModel();
            var departmentList = await departmentsDto.Departments;

            var regionsList = new List<ListRegionViewModel>();

            foreach (var regionDto in regions)
            {
                var departmentDto = departmentList.Where(q => q.Regionnr == regionDto.Nr).ToList();
                var fullDepartmens = string.Empty;

                foreach (var dto in departmentDto)
                {
                    fullDepartmens += dto.Title;
                    fullDepartmens += ", ";
                }

                regionsList.Add(new ListRegionViewModel
                {
                    Nr = regionDto.Nr,
                    Title = regionDto.Title,
                    Departments = fullDepartmens.Remove(fullDepartmens.Length-2)
                });
            }

            DefaultViewModel["Regions"] = regionsList.OrderBy(q => q.Title);


            try
            {
                var cachedData = await _cacheProvider.Read();
                if (cachedData != null)
                {
                    if (cachedData.CacheDateTime.AddHours(4) >= DateTime.Now)
                    {
                        DataBinding(cachedData);
                    }
                    else
                    {
                        LoadData();
                    }
                }
                else
                {
                    LoadData();
                }
            }
            catch (Exception exception)
            {
                throw new Exception(_resourceLoader.GetString("ErrorCacheLoad"), exception);
            }
        }

        private async void LoadData()
        {
            if (!App.IsNetworkAvailable)
            {
                throw new Exception(_resourceLoader.GetString("ErrorNoInternet"));
            }

            try
            {
                if (_statusBar != null) await _statusBar.ProgressIndicator.ShowAsync();

                var sauktiniai = new Sauktinis(App.Url);
                var sauktiniaiInfo = await sauktiniai.GetData();

                var naujienosRequest = new Naujienos(App.UrlNaujienos);
                var naujienos = await naujienosRequest.GetData();
                sauktiniaiInfo.Naujienos = naujienos.Naujienos;

                DataBinding(sauktiniaiInfo);

                _cacheProvider.Write(sauktiniaiInfo);
            }
            finally
            {
                if (_statusBar != null) _statusBar.ProgressIndicator.HideAsync();
            }
        }

        private void DataBinding(SauktinisModel sauktiniaiInfo)
        {
            DefaultViewModel["Savanoriai"] = sauktiniaiInfo.Viso;
            var percent = (double)sauktiniaiInfo.Viso / 3000;
            DefaultViewModel["SavanoriuDalis"] = percent.ToString("P", CultureInfo.InvariantCulture);

            DefaultViewModel["Apygardos"] = sauktiniaiInfo.Rinktines;
            DefaultViewModel["Naujienos"] = sauktiniaiInfo.Naujienos;
        }

        private void SetCountDown()
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };

            timer.Tick += (o, o1) =>
            {
                var now = DateTime.Now;
                var difference = (int)(App.TargetDateSauktiniai - now).TotalSeconds;
                var differenceList = 0;

                if (difference >= 0)
                {
                    DefaultViewModel["TimeLeft"] = (App.TargetDateSauktiniai - now).ToString(@"dd\ \d\.\ hh\:mm\:ss");
                }
                else
                {
                    differenceList = (int)(App.TargetDateListSauktiniai - now).TotalSeconds;

                    if (differenceList >= 0)
                    {
                        var element = FindChildControl<TextBlock>(this, "TextBlockThirdTitle") as TextBlock;
                        if (element != null) element.Text = _resourceLoader.GetString("PaskelbtiSauktiniaiBus");
                        DefaultViewModel["TimeLeft"] = (App.TargetDateListSauktiniai - now).ToString(@"dd\ \d\.\ hh\:mm\:ss");
                    }
                    else
                    {
                        DefaultViewModel["TimeLeft"] = _resourceLoader.GetString("TimeLeftEnd");
                    }
                }

                if (difference < 0 && differenceList < 0)
                {
                    timer.Stop();
                }
            };
            timer.Start();
        }
        private DependencyObject FindChildControl<T>(DependencyObject control, string ctrlName)
        {
            var childNumber = VisualTreeHelper.GetChildrenCount(control);
            for (var i = 0; i < childNumber; i++)
            {
                var child = VisualTreeHelper.GetChild(control, i);
                var fe = child as FrameworkElement;
                // Not a framework element or is null
                if (fe == null) return null;

                if (child is T && fe.Name == ctrlName)
                {
                    // Found the control so return
                    return child;
                }
                // Not found it - search children
                var nextLevel = FindChildControl<T>(child, ctrlName);
                if (nextLevel != null)
                    return nextLevel;
            }
            return null;
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
            // TODO: Save the unique state of the page here.
        }

        private void Naujienos_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedItem = ((NaujienaModel)e.ClickedItem);
            if (!Frame.Navigate(typeof(Naujiena), clickedItem))
            {
                throw new Exception(_resourceLoader.GetString("NavigationFailedExceptionMessage"));
            }
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the
        /// <see>
        ///     <cref>NavigationHelper.LoadState</cref>
        /// </see>
        ///     and <see>
        ///         <cref>NavigationHelper.SaveState</cref>
        ///     </see>
        ///     .
        /// The navigation parameter is available in the LoadState method
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void AboutPage_OnClick(object sender, RoutedEventArgs e)
        {
            if (!Frame.Navigate(typeof(AboutPage)))
            {
                throw new Exception(_resourceLoader.GetString("NavigationFailedExceptionMessage"));
            }
        }

        private void Refresh_OnClick(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void KurKreiptis_OnClick(object sender, RoutedEventArgs e)
        {
            if (!Frame.Navigate(typeof(KurKreiptis)))
            {
                throw new Exception(_resourceLoader.GetString("NavigationFailedExceptionMessage"));
            }
        }

        private void Region_OnItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedItem = ((ListRegionViewModel)e.ClickedItem);
            if (!Frame.Navigate(typeof(RegionListPage), clickedItem))
            {
                throw new Exception(_resourceLoader.GetString("NavigationFailedExceptionMessage"));
            }
        }

        private void Search_OnClick(object sender, RoutedEventArgs e)
        {
            if (!Frame.Navigate(typeof(SearchPage)))
            {
                throw new Exception(_resourceLoader.GetString("NavigationFailedExceptionMessage"));
            }
        }
    }
}
