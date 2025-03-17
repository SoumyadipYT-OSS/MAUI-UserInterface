using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;

namespace _34_Switch {
    public class CustomThemeThumbSwitch : ContentView {
        public event EventHandler<ToggledEventArgs>? Toggled;

        private readonly Image _thumbImage;
        private readonly Grid _thumbContainer;
        private readonly BoxView _track;
        private readonly Border _thumbBorder;
        private bool _isToggled;

        public CustomThemeThumbSwitch() {
            _track = new BoxView {
                Color = Colors.LightGray,
                HeightRequest = 30,
                WidthRequest = 50, // Ensure the track size fits the thumb
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                CornerRadius = new CornerRadius(20),
                BackgroundColor = Colors.Transparent
            };

            _thumbImage = new Image {
                Source = "moon.png",
                WidthRequest = 40, // Ensure the thumb size fits within the track
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };

            _thumbBorder = new Border {
                Content = _thumbImage,
                WidthRequest = 40, // Ensure the thumb size fits within the track
                HeightRequest = 40,
                StrokeShape = new RoundRectangle { CornerRadius = new CornerRadius(20) },
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Colors.DarkBlue,
                Padding = 0,
                Stroke = Colors.DarkGoldenrod,
                StrokeThickness = 3
            };

            _thumbContainer = new Grid {
                WidthRequest = 30,
                HeightRequest = 30, // Ensure thumb container size is accurate
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Start, // Initially align it to the start
                Children = { _thumbBorder }
            };

            var grid = new Grid {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                //BackgroundColor = Colors.Blue,   /* This part helps me to know the total area cover the button */
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(10) } // Ensure the column size fits the thumb container
                },
                Children = { _track, _thumbContainer }
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnSwitchToggled!;
            grid.GestureRecognizers.Add(tapGestureRecognizer);

            Content = grid;
        }

        private void OnSwitchToggled(object sender, EventArgs e) {
            _isToggled = !_isToggled;

            if (_isToggled) {
                _track.Color = Colors.RosyBrown;
                _thumbBorder.BackgroundColor = Colors.OliveDrab;
                _thumbBorder.Stroke = Colors.MediumVioletRed;
            } else {
                _track.Color = Colors.LightGray;
                _thumbBorder.BackgroundColor = Colors.DarkBlue;
                _thumbBorder.Stroke = Colors.DarkGoldenrod;
            }

            _thumbImage.Source = _isToggled ? "sun.png" : "moon.png"; // Change the image based on the switch state
            _thumbContainer.HorizontalOptions = _isToggled ? LayoutOptions.End : LayoutOptions.Start;

            // Animate the thumb movement
            var translation = _isToggled ? (_track.Width - _thumbContainer.Width) / 2 : -(_track.Width - _thumbContainer.Width) / 2;
            var animation = new Animation(v => _thumbContainer.TranslationX = v,
                                          _thumbContainer.TranslationX,
                                          translation);
            animation.Commit(this, "SwitchThumbAnimation", length: 650, easing: Easing.SpringOut);

            // Raise the Toggled event
            Toggled?.Invoke(this, new ToggledEventArgs(_isToggled));
        }
    }
}
