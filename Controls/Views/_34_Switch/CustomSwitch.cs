using Microsoft.Maui.Controls;

namespace _34_Switch
{
    public class CustomSwitch : ContentView
    {
        private readonly Image _switchImage;
        private readonly Switch _switch;

        public CustomSwitch() {
            _switch = new() {
                Scale = 2
            };
            _switch.Toggled += OnCustomSwitchToggled!;

            _switchImage = new Image {
                Source = "moon.png"
            };

            var stackLayout = new StackLayout {
                Orientation = StackOrientation.Horizontal,
                Children = { _switchImage, _switch }
            };

            Content = stackLayout;
        }

        private void OnCustomSwitchToggled(object sender, ToggledEventArgs e) {
            _switchImage.Source = e.Value ? "sun.png" : "moon.png";
        }
    }
}