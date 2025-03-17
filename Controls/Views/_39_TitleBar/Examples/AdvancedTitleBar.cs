using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace _39_TitleBar.Examples {
    public class AdvancedTitleBar : Grid {
        public Label TitleLabel { get; private set; }
        public Button MenuButton { get; private set; }
        public Button ProfileButton { get; private set; }
        public SearchBar SearchBar { get; private set; }

        public string TitleText {
            get => TitleLabel.Text;
            set => TitleLabel.Text = value;
        }

        public AdvancedTitleBar() {
            // Define the grid layout
            BackgroundColor = Colors.DarkSlateBlue;
            Padding = new Thickness(10);
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto }); // Menu button
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto }); // Title
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star }); // Search Bar
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto }); // Profile button

            // Menu Button
            MenuButton = new Button {
                Text = "☰", // Hamburger menu icon
                FontSize = 24,
                BackgroundColor = Colors.Transparent,
                TextColor = Colors.White,
                VerticalOptions = LayoutOptions.Center
            };
            MenuButton.Clicked += (s, e) => {
                Application.Current?.Windows[0]?.Page?.DisplayAlert("Menu", "Menu button clicked!", "OK");
            };
            Children.Add(MenuButton);
            Grid.SetColumn(MenuButton, 0);
            Grid.SetRow(MenuButton, 0);

            // Title Label
            TitleLabel = new Label {
                Text = "MAUI App",
                FontSize = 16,
                Padding = 2,
                TextColor = Colors.White,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
            Children.Add(TitleLabel);
            Grid.SetColumn(MenuButton, 1);
            Grid.SetRow(MenuButton, 0);

            // Search Bar
            SearchBar = new SearchBar {
                Placeholder = "Search...",
                BackgroundColor = Colors.White,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Fill
            };
            Children.Add(SearchBar);
            Grid.SetColumn(SearchBar, 2);
            Grid.SetRow(SearchBar, 0);

            // Profile Button
            ProfileButton = new Button {
                Text = "👤", // Profile icon
                FontSize = 24,
                BackgroundColor = Colors.Transparent,
                TextColor = Colors.White,
                VerticalOptions = LayoutOptions.Center
            };
            ProfileButton.Clicked += (s, e) => {
                Application.Current?.Windows[0]?.Page?.DisplayAlert("Profile", "Profile button clicked!", "OK");
            };
            Children.Add(ProfileButton);
            Grid.SetColumn(ProfileButton, 3);
            Grid.SetRow(ProfileButton, 0);
        }
    }
}