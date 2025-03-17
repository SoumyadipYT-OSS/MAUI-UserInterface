using Microsoft.Maui.Controls;

namespace _39_TitleBar.Examples {
    public class BasicTitlebar : Grid {
        public SearchBar Search { get; private set; }
        public Label TitleLabel { get; private set; }
        public Button SettingButton { get; private set; }

        public string TitleText {
            get => TitleLabel.Text;
            set => TitleLabel.Text = value;
        }

        public BasicTitlebar() {
            // Set up the grid layout
            BackgroundColor = Colors.SkyBlue;
            Padding = new Thickness(10);
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            // Title Label
            TitleLabel = new Label {
                Text = "Maui App",
                FontSize = 16,
                Padding = 4,
                TextColor = Colors.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Start
            };
            Children.Add(TitleLabel);
            Grid.SetColumn(TitleLabel, 0);
            Grid.SetRow(TitleLabel, 0);

            // Search Bar
            Search = new SearchBar {
                Placeholder = "Search here...",
                TextColor = Microsoft.Maui.Graphics.Colors.SteelBlue,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Fill,
                BackgroundColor = Colors.White
            };
            Children.Add(Search);
            Grid.SetColumn(Search, 1);
            Grid.SetRow(Search, 0);

            // Setting Button
            SettingButton = new Button {
                Text = "⚙️", // Gear icon
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.End,
                BackgroundColor = Microsoft.Maui.Graphics.Colors.Transparent
            };
            Children.Add(SettingButton);
            Grid.SetColumn(SettingButton, 2);
            Grid.SetRow(SettingButton, 0);


            // Optional: Add event to the button
            SettingButton.Clicked += (s, e) => {
                var currentPage = Application.Current?.Windows[0]?.Page;
                currentPage?.DisplayAlert("Settings", "Settings button clicked!", "OK");
            };

        }
    }
}