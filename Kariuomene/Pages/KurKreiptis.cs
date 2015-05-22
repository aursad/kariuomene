using Windows.ApplicationModel.Resources;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Kariuomene.Common;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Kariuomene.DataModel;

namespace Kariuomene.Pages
{
    public sealed partial class KurKreiptis : Page
    {
        private readonly NavigationHelper _navigationHelper;
        private readonly ResourceLoader _resourceLoader = ResourceLoader.GetForCurrentView("Resources");
        private readonly ObservableDictionary _defaultViewModel = new ObservableDictionary();
        private readonly KurKreiptisDataModel _placesDataModel = new KurKreiptisDataModel();

        public KurKreiptis()
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
            var geolocator = new Geolocator();
            try
            {
                var geoposition = await geolocator.GetGeopositionAsync();

                if (geoposition != null) MapControl.Center = geoposition.Coordinate.Point;
                MapControl.ZoomLevel = 12;
            }
            catch (Exception)
            {
                MapControl.ZoomLevel = 6;
                MapControl.Center = new Geopoint(new BasicGeoposition
                {
                    Latitude = 55.16013,
                    Longitude = 23.55505
                });
            }
            finally
            {
                MapControl.LandmarksVisible = true;

                foreach (var kurKreiptisLocationModel in _placesDataModel.List)
                {
                    var itemGeoPoint = new Geopoint(new BasicGeoposition
                    {
                        Latitude = kurKreiptisLocationModel.Latitude,
                        Longitude = kurKreiptisLocationModel.Longitude
                    });
                    var newPinItem = CreatePin(kurKreiptisLocationModel);
                    MapControl.Children.Add(newPinItem);

                    MapControl.SetLocation(newPinItem, itemGeoPoint);
                    MapControl.SetNormalizedAnchorPoint(newPinItem, new Point(0.0, 1.0));
                }
            }
        }
        private DependencyObject CreatePin(KurKreiptisLocationModel kurKreiptisData)
        {
            //Creating a Grid element.
            var myGrid = new Grid();
            myGrid.RowDefinitions.Add(new RowDefinition());
            myGrid.RowDefinitions.Add(new RowDefinition());
            myGrid.Background = new SolidColorBrush(Colors.Transparent);

            //Creating a Rectangle
            var myRectangle = new Rectangle
            {
                Fill = new SolidColorBrush(Colors.Black), 
                Height = 20, 
                Width = 20
            };
            myRectangle.SetValue(Grid.RowProperty, 0);
            myRectangle.SetValue(Grid.ColumnProperty, 0);

            //Adding the Rectangle to the Grid
            myRectangle.Tapped += MyPinClick_Rectangle;
            myRectangle.DataContext = kurKreiptisData;

            myGrid.Children.Add(myRectangle);

            //Creating a Polygon
            var myPolygon = new Polygon
            {
                Points = new PointCollection { new Point(0, 0), new Point(20, 0), new Point(2, 40) },
                Fill = new SolidColorBrush(Colors.Black)
            };
            myPolygon.SetValue(Grid.RowProperty, 1);
            myPolygon.SetValue(Grid.ColumnProperty, 0);

            myPolygon.Tapped += MyPinClick_Polygon;
            myPolygon.DataContext = kurKreiptisData;
            //Adding the Polygon to the Grid
            myGrid.Children.Add(myPolygon);
            return myGrid;
        }

        private void MyPinClick_Rectangle(object sender, TappedRoutedEventArgs tappedRoutedEventArgs)
        {
            var rectangle = sender as Rectangle;
            if (rectangle != null)
            {
                if (rectangle.DataContext != null)
                {
                    var item = rectangle.DataContext as KurKreiptisLocationModel;

                    if (item != null)
                    {
                        Dialog(item);
                    }
                }
            }
        }

        private void MyPinClick_Polygon(object sender, TappedRoutedEventArgs tappedRoutedEventArgs)
        {
            var rectangle = sender as Polygon;
            if (rectangle != null)
            {
                var item = rectangle.DataContext as KurKreiptisLocationModel;

                if (item != null)
                {
                    Dialog(item);
                }
            }
        }

        private async void Dialog(KurKreiptisLocationModel model)
        {
            AlertMessage.PrimaryButtonText = _resourceLoader.GetString("Close");
            AlertMessage.DataContext = model;
            AlertMessage.PrimaryButtonClick += (sender, args) => AlertMessage.Hide();

            await AlertMessage.ShowAsync();
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
