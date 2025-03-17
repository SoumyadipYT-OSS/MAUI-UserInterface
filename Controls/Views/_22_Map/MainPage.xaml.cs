using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace _22_Map
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Event handler requires this parameter")]
        private void Map_MapClicked(object? sender, Microsoft.Maui.Controls.Maps.MapClickedEventArgs e) {
            var pin = new Pin {
                Type = PinType.Place,
                Label = "Clicked location",
                Address = $"{e.Location.Latitude}, {e.Location.Longitude}\n{e.Location}",
                Location = e.Location
            };

            map.Pins.Add(pin);
        }

        private async void OnSearchButtonPressed(object sender, EventArgs e) {
            string address = locationSearchBar.Text;

            if (!string.IsNullOrEmpty(address)) {
                var locations = await Geocoding.GetLocationsAsync(address);
                var location = locations?.FirstOrDefault();

                if (location != null) {
                    map.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(location.Latitude, location.Longitude), Distance.FromKilometers(1)));

                    var pin = new Pin {
                        Label = address,
                        Location = new Location(location.Latitude, location.Longitude)
                    };

                    map.Pins.Add(pin);
                } else {
                    await DisplayAlert("Error", "Location not found", "OK");
                }
            }
        }

        private async void OnGetDirectionsButtonClicked(object sender, EventArgs e) {
            string initialLocation = initialLocationEntry.Text;
            string destination = destinationEntry.Text;

            if (string.IsNullOrEmpty(destination)) {
                await DisplayAlert("Error", "Please enter a destination", "OK");
                return;
            }


            Location initialPosition;
            if (string.IsNullOrEmpty(initialLocation)) {
                // Get current location
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location == null) {
                    await DisplayAlert("Error", "Unable to get current location", "OK");
                    return;
                }

                initialPosition = new Location(location.Latitude, location.Longitude);
            } else {
                var locations = await Geocoding.GetLocationsAsync(initialLocation);
                initialPosition = locations.FirstOrDefault()!;

                if (initialPosition == null) {
                    await DisplayAlert("Error", "Initial location not found", "OK");
                    return;
                }
            }


            var destinationLocations = await Geocoding.GetLocationsAsync(destination);
            var destinationPosition = destinationLocations?.FirstOrDefault();

            if (destinationPosition == null) {
                await DisplayAlert("Error", "Destination not found", "OK");
                return;
            }

            // Draw route on the map (simple straight line for example purposes)
            var polyline = new Polyline {
                StrokeColor = Colors.PaleGoldenrod,
                StrokeWidth = 5
            };
            polyline.Geopath.Add(initialPosition);
            polyline.Geopath.Add(new Location(destinationPosition.Latitude, destinationPosition.Longitude));

            map.MapElements.Add(polyline);


            // Move the map to show the route
            var routelocations = new List<Location> {
                initialPosition,
                new(destinationPosition.Latitude, destinationPosition.Longitude)
            };
            var bounds = new MapSpan(routelocations[0], 0.01, 0.01);     // Need adjustment span
            map.MoveToRegion(bounds);
        }
    }

}
