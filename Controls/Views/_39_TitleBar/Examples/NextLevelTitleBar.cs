using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace _39_TitleBar.Examples {
    public class NextLevelTitleBar : Grid {

        public Label TitleLabel { get; private set; }
        public Button NotificationButton { get; private set; }
        public ImageButton ProfileButton { get; private set; }
        public SearchBar SearchBar { get; private set; }

        public string TitleText {
            get => TitleLabel.Text;
            set => TitleLabel.Text = value;
        }


        public NextLevelTitleBar() {
            // Define a dynamic gradient background
            this.Background = new LinearGradientBrush {
                GradientStops =
                [
                    new GradientStop { Color = Colors.Purple, Offset = 0.0f },
                    new GradientStop { Color = Colors.Blue, Offset = 1.0f }
                ]
            };

            Padding = new Thickness(6);
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto }); // Title
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star }); // Search Bar
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto }); // Notification
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto }); // Profile

            // Title Label
            TitleLabel = new Label {
                Text = "MAUI",
                FontSize = 16,
                Padding = 2,
                TextColor = Colors.White,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Start
            };
            Children.Add(TitleLabel);
            Grid.SetColumn(TitleLabel, 0);
            Grid.SetRow(TitleLabel, 0);

            // Search Bar
            SearchBar = new SearchBar {
                Placeholder = "Search here...",
                BackgroundColor = Colors.White,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
            };
            Children.Add(SearchBar);
            Grid.SetColumn(SearchBar, 1);
            Grid.SetRow(SearchBar, 0);

            // Notification Button
            NotificationButton = new Button {
                Text = "🔔", // Bell icon
                FontSize = 18,
                BackgroundColor = Colors.Transparent,
                TextColor = Colors.White,
                VerticalOptions = LayoutOptions.Center
            };

            NotificationButton.Clicked += (s, e) => {
                // Expandable menu logic (e.g., open a flyout menu or display settings)
                Application.Current?.Windows[0]?.Page?.DisplayAlert("Profile", "Profile menu opened!", "OK");
            };



            Children.Add(NotificationButton);
            Grid.SetColumn(NotificationButton, 2);
            Grid.SetRow(NotificationButton, 0);

            // Profile Button
            ProfileButton = new ImageButton {
                Source = "profile.png", // Replace with an actual profile image
                BackgroundColor = Colors.Transparent,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 40,
                HeightRequest = 40
            };
            ProfileButton.Clicked += (s, e) => {
                // Expandable menu logic (e.g., open a flyout menu or display settings)
                Application.Current?.Windows[0]?.Page?.DisplayAlert("Profile", "Profile menu opened!", "OK");
            };
            Children.Add(ProfileButton);
            Grid.SetColumn(ProfileButton, 3);
            Grid.SetRow(ProfileButton, 0);

            // Animate the Search Bar when Search Icon (Bell) is clicked
            NotificationButton.Clicked += (s, e) => {
                if (SearchBar.IsVisible) {
                    SearchBar.FadeTo(0, 250);
                    SearchBar.IsVisible = false;
                } else {
                    SearchBar.IsVisible = true;
                    SearchBar.FadeTo(1, 250);
                }
            };
        }
    }
}