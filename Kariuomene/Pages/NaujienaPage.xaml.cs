using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using Windows.Storage.Streams;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Imaging;
using Kariuomene.Common;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Kariuomene.DataModel;
using Kariuomene.ViewModel;

namespace Kariuomene.Pages
{
    public sealed partial class Naujiena : Page
    {
        private readonly NavigationHelper _navigationHelper;
        private readonly ObservableDictionary _defaultViewModel = new ObservableDictionary();
        private readonly StatusBar _statusBar = StatusBar.GetForCurrentView();
        private readonly ResourceLoader _resourceLoader = ResourceLoader.GetForCurrentView("Resources");
        private readonly CacheProvider _cacheProvider = new CacheProvider();

        public Naujiena()
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
            var naujiena = (NaujienaModel)e.NavigationParameter;
            try
            {
                await _statusBar.ProgressIndicator.ShowAsync();

                var readItem = await _cacheProvider.Read(naujiena);
                if (readItem.Cached != null)
                {
                    NaujienaImage.Source = await ConvertToBitmapImage(readItem.Image);

                    DefaultViewModel["Naujiena"] = readItem;
                }
                else
                {
                    if (!App.IsNetworkAvailable)
                    {
                        throw new Exception(_resourceLoader.GetString("ErrorNoInternet"));
                    }

                    var naujienosRequest = await new Naujienos().GetFullNaujienaModel(naujiena);

                    naujienosRequest.Publish = string.Format("{0} {1}", _resourceLoader.GetString("Paskelbta"),
                        naujienosRequest.Publish);
                    naujienosRequest.FullText = System.Net.WebUtility.HtmlDecode(naujienosRequest.FullText);
                    NaujienaImage.Source = await ConvertToBitmapImage(naujienosRequest.Image);

                    DefaultViewModel["Naujiena"] = naujienosRequest;

                    _cacheProvider.Write(naujienosRequest);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(_resourceLoader.GetString("ErrorCacheLoad"), exception);
            }
            finally
            {
                if (_statusBar != null) _statusBar.ProgressIndicator.HideAsync();
            }
        }

        private async Task<BitmapImage> ConvertToBitmapImage(byte[] imageBytes)
        {
            var image = new BitmapImage();
            using (var ms = new InMemoryRandomAccessStream())
            {
                using (var writer = new DataWriter(ms.GetOutputStreamAt(0)))
                {
                    writer.WriteBytes(imageBytes);
                    await writer.StoreAsync();
                }
                image.SetSource(ms);
            }

            return image;
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

        private async void OpenInBrowser(object sender, RoutedEventArgs e)
        {
            var naujiena = DefaultViewModel["Naujiena"] as NaujienaModel;

            if (naujiena != null)
            {
                await Windows.System.Launcher.LaunchUriAsync(new Uri(naujiena.Url));
            }
        }
    }
}
