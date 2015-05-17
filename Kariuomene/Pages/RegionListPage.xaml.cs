using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Kariuomene.Common;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Kariuomene.DataModel;
using Kariuomene.ViewModel;
using Newtonsoft.Json;

namespace Kariuomene.Pages
{
    public sealed partial class RegionListPage : Page
    {
        private readonly NavigationHelper _navigationHelper;
        private readonly ObservableDictionary _defaultViewModel = new ObservableDictionary();
        private readonly StatusBar _statusBar = StatusBar.GetForCurrentView();
        private const int ItemPerPage = 50;
        private int _loadedItem;
        private int _regionNr;
        private ListRegionViewModel _regionDto;
        private const string UrlRegionList = "http://sauktiniai.kam.lt/list.php?region={0}";
        private IList<DepartmentDto> _departmentList;


        public RegionListPage()
        {
            InitializeComponent();

            PreviousAppBarButton.Visibility = Visibility.Collapsed;
            NavigationCacheMode = NavigationCacheMode.Required;

            _navigationHelper = new NavigationHelper(this);
            _navigationHelper.LoadState += NavigationHelper_LoadState;
            _navigationHelper.SaveState += NavigationHelper_SaveState;
        }

        public NavigationHelper NavigationHelper
        {
            get { return _navigationHelper; }
        }

        public ObservableDictionary DefaultViewModel
        {
            get { return _defaultViewModel; }
        }

        private async void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            try
            {
                _regionDto = (ListRegionViewModel)e.NavigationParameter;
                DefaultViewModel["Region"] = _regionDto;
                _regionNr = _regionDto.Nr;

                var departmentsDto = new DepartmentDataModel();
                _departmentList = await departmentsDto.Departments;

                await _statusBar.ProgressIndicator.ShowAsync();

                LoadItem(_loadedItem, _loadedItem + ItemPerPage - 1);
            }
            catch (Exception exception)
            {
                throw new Exception("Nepavyko užkrauti regiono sąrašo!", exception);
            }
            finally
            {
                if (_statusBar != null) _statusBar.ProgressIndicator.HideAsync();
            }
        }

        private async void LoadItem(int start, int end)
        {
            try
            {
                _statusBar.ProgressIndicator.Text = "Kraunasi duomenys...";
                await _statusBar.ProgressIndicator.ShowAsync();

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Referrer = new Uri("http://sauktiniai.kam.lt/");
                    client.DefaultRequestHeaders.Range = new RangeHeaderValue(start, end);

                    _loadedItem = end;

                    var dataObject = await client.GetStringAsync(new Uri(string.Format(UrlRegionList, _regionNr)));
                    if (!string.IsNullOrWhiteSpace(dataObject))
                    {
                        var rootObject = JsonConvert.DeserializeObject<List<SearchInfoDto>>(dataObject);

                        foreach (var searchInfoDto in rootObject)
                        {
                            var department = _departmentList.FirstOrDefault(q => q.Id == Convert.ToInt16(searchInfoDto.Department));
                            if (department != null)
                            {
                                searchInfoDto.DepartmentTitle = department.Title;
                            }
                        }

                        ListView.ItemsSource = rootObject;

                        PreviousAppBarButton.Visibility = start >= ItemPerPage ? Visibility.Visible : Visibility.Collapsed;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Nepavyksta gauti duomenų.", e);
            }
            finally
            {
                if (_statusBar != null) _statusBar.ProgressIndicator.HideAsync();
            }
        }

        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void BackToPriviousPage(object sender, RoutedEventArgs e)
        {
            var endCount = _loadedItem - ItemPerPage;
            LoadItem(endCount - ItemPerPage + 1, endCount);
        }

        private void OpenNextPage(object sender, RoutedEventArgs e)
        {
            LoadItem(_loadedItem + 1, _loadedItem + ItemPerPage);
        }
    }
}
