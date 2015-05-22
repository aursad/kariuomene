using System.Net.Http;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Kariuomene.Common;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Kariuomene.ViewModel;
using Newtonsoft.Json;

namespace Kariuomene.Pages
{
    public sealed partial class SearchPage : Page
    {
        private readonly NavigationHelper _navigationHelper;
        private readonly ObservableDictionary _defaultViewModel = new ObservableDictionary();
        private const string UrlSearch = "http://sauktiniai.kam.lt/search.php?name={0}&lastname={1}&bdate={2}&code={3}&callback=";
        private readonly StatusBar _statusBar = StatusBar.GetForCurrentView();
        private readonly ResourceLoader _resourceLoader = ResourceLoader.GetForCurrentView("Resources");

        public SearchPage()
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

        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            DatePicker.MaxYear = new DateTimeOffset(new DateTime(1997, 1, 1));
            DatePicker.MinYear = new DateTimeOffset(new DateTime(1986, 1, 1));
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

        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            NameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            NinTextBox.Text = string.Empty;
        }

        private async void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {
            var errorMessageList = string.Empty;

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                errorMessageList += "Neįvestas vardas!\n";
            }
            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                errorMessageList += "Neįvesta pavardė!\n";
            }
            if (string.IsNullOrWhiteSpace(NinTextBox.Text))
            {
                errorMessageList += "Neįvesti du paskutiniai asmens kodo skaičiai!\n";
            }

            if (errorMessageList == string.Empty)
            {
                var urlRequest = string.Format(UrlSearch, NameTextBox.Text, LastNameTextBox.Text, DatePicker.Date.ToString("yyyy-M-d"), NinTextBox.Text);
                var data = await GetData(urlRequest);

                if (data.Success)
                {
                    if (!Frame.Navigate(typeof(SearchDetailsPage), data.Data))
                    {
                        throw new Exception(_resourceLoader.GetString("NavigationFailedExceptionMessage"));
                    }
                }
                else
                {
                    var message = new MessageDialog(data.Message);
                    await message.ShowAsync();
                }
            }
            else
            {
                var message = new MessageDialog(errorMessageList)
                {
                    Title = "Klaida"
                };
                await message.ShowAsync();
            }
        }

        private async Task<SearchViewModel> GetData(string url)
        {
            try
            {
                _statusBar.ProgressIndicator.Text = "Ieškoma...";
                await _statusBar.ProgressIndicator.ShowAsync();

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Referrer = new Uri("http://sauktiniai.kam.lt/");
                    var dataObject = await client.GetStringAsync(new Uri(url));
                    if (!string.IsNullOrWhiteSpace(dataObject))
                    {
                        dataObject = dataObject.Substring(1, dataObject.Length - 2);

                        var rootObject = JsonConvert.DeserializeObject<SearchViewModel>(dataObject);
                        return rootObject;
                    }
                }
                return null;
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

        private async void Toc_OnClick(object sender, RoutedEventArgs e)
        {
            const string messageText = @"Mobilioji aplikacija nerenka ir nesaugo jokių asmeninių duomenų, kurie pateikiami paieškos formoje, kaip Jūsų vardas, pavardė, gimimo metai,
asmens kodo du paskutiniai skaičiai.";
            var message = new MessageDialog(messageText)
            {
                Title = "Privatumo politika"
            };

            await message.ShowAsync();
        }
    }
}
