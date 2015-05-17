using System.Linq;
using Windows.UI.ViewManagement;
using Kariuomene.Common;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Kariuomene.DataModel;
using Kariuomene.ViewModel;

namespace Kariuomene.Pages
{
    public sealed partial class SearchDetailsPage : Page
    {
        private readonly NavigationHelper _navigationHelper;
        private readonly ObservableDictionary _defaultViewModel = new ObservableDictionary();
        private readonly StatusBar _statusBar = StatusBar.GetForCurrentView();

        public SearchDetailsPage()
        {
            InitializeComponent();

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
                _statusBar.ProgressIndicator.Text = "Duomenys kraunasi...";
                await _statusBar.ProgressIndicator.ShowAsync();

                var searchData = (SearchDto)e.NavigationParameter;

                DefaultViewModel["FullName"] = string.Format("{0} {1}", searchData.Info.Name, searchData.Info.Lastname);
                DefaultViewModel["SearchInfo"] = searchData.Info;

                var dataRegion = new RegionDataModel();
                var regions = await dataRegion.Regions;

                DefaultViewModel["Region"] = regions.FirstOrDefault(q => q.Nr == Convert.ToInt16(searchData.Info.Region));
            }
            catch (Exception)
            {
                throw new Exception("Nepavyko užkrauti duomenų.");
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
    }
}
