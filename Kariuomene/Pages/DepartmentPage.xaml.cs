using System.Linq;
using Kariuomene.Common;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Kariuomene.DataModel;

namespace Kariuomene.Pages
{
    public sealed partial class DepartmentPage : Page
    {
        private readonly NavigationHelper _navigationHelper;
        private readonly ObservableDictionary _defaultViewModel = new ObservableDictionary();

        public DepartmentPage()
        {
            InitializeComponent();

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
            var regionDto = (RegionDto)e.NavigationParameter;

            var departmentsDto = new DepartmentDataModel();
            var departmentList = await departmentsDto.Departments;

            var departmentDto = departmentList.Where(q => q.Regionnr == regionDto.Nr).ToList();

            DefaultViewModel["Department"] = departmentDto;
            DefaultViewModel["RegionTitle"] = regionDto.Title;
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
