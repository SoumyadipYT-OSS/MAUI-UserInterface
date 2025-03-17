using Microsoft.Maui.Controls;

namespace _36_TableView.TableClass
{
    public class AdvancedTable : ContentPage
    {
        public AdvancedTable() {
            Title = "Advanced TableView";

            // Create the TableView and set overall properties.
            var tableView = new TableView {
                Intent = TableIntent.Form,
                HasUnevenRows = true
            };

            // Create the TableRoot with a title
            var tableRoot = new TableRoot("Advanced Information");


            // ---------------------------
            // Section 1: User Profile
            // ---------------------------
            var userProfileSection = new TableSection("User Profile");

            // Create a custom ViewCell for the user profile
            var userProfileCell = new ViewCell();

            // Build the layout using a Grid
            var gridProfile = new Grid {
                Padding = new Thickness(10),
                BackgroundColor = Microsoft.Maui.Graphics.Colors.LightBlue
            };


            /* Two-column layout: an image on the left and stacked labels on the right */
            gridProfile.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            gridProfile.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });


            // profile icon
            var userIcon = new Image {
                Source = "usericon.png",
                WidthRequest = 40,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 0, 10, 0)
            };
            gridProfile.Children.Add(userIcon);
            Grid.SetColumn(userIcon, 0);



            var stackProfile = new StackLayout { VerticalOptions = LayoutOptions.Center };

            var titleLabel = new Label {
                Text = "Aparesh Kumar",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.Orchid
            };
            stackProfile.Children.Add(titleLabel);


            var detailLabel = new Label {
                Text = "Administrator",
                FontSize = 14,
                TextColor = Microsoft.Maui.Graphics.Colors.BlueViolet
            };
            stackProfile.Children.Add(detailLabel);

            gridProfile.Children.Add(stackProfile);
            Grid.SetColumn(stackProfile, 1);


            // Assign the grid layout to the ViewCell.
            userProfileCell.View = gridProfile;
            userProfileSection.Add(userProfileCell);

            // --------------------------
            // Section 2: Settings
            // --------------------------
            var settingsSection = new TableSection("Settings");

            // Cell 1: Enable Notifications
            var notificationsCell = new ViewCell();
            var gridNotification = new Grid {
                Padding = new Thickness(10),
                BackgroundColor = Microsoft.Maui.Graphics.Colors.PaleGoldenrod 
            };

            // Define two columns: one for the label and one for the switch.
            gridNotification.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gridNotification.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            var notificationsLabel = new Label {
                Text = "Enable Notifications",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center
            };
            gridNotification.Children.Add(notificationsLabel);
            Grid.SetColumn(notificationsLabel, 0);

            var notificationsSwitch = new Switch {
                IsToggled = true, // Default value
                VerticalOptions = LayoutOptions.Center
            };
            gridNotification.Children.Add(notificationsSwitch);
            Grid.SetColumn(notificationsSwitch, 1);

            notificationsCell.View = gridNotification;
            settingsSection.Add(notificationsCell);

            // Cell 2: Dark Mode
            var darkModeCell = new ViewCell();
            var gridDarkMode = new Grid {
                Padding = new Thickness(10),
                BackgroundColor = Microsoft.Maui.Graphics.Colors.OliveDrab
            };

            gridDarkMode.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gridDarkMode.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            var darkModeLabel = new Label {
                Text = "Dark Mode",
                FontSize = 20,
                VerticalOptions = LayoutOptions.Center
            };
            gridDarkMode.Children.Add(darkModeLabel);
            Grid.SetColumn(darkModeLabel, 0);

            var darkModeSwitch = new Switch {
                IsToggled = false, // Default value
                VerticalOptions = LayoutOptions.Center
            };
            gridDarkMode.Children.Add(darkModeSwitch);
            Grid.SetColumn(darkModeSwitch, 1);

            darkModeCell.View = gridDarkMode;
            settingsSection.Add(darkModeCell);

            // --------------------------
            // Combine Sections into TableRoot
            // --------------------------
            tableRoot.Add(userProfileSection);
            tableRoot.Add(settingsSection);

            tableView.Root = tableRoot;

            // --------------------------
            // Optional: Add Gesture Recognizers
            // --------------------------
            // If you need to handle tapping on a cell, wrap your cell content
            // (for example, gridNotification) inside a GestureRecognizer.
            // Example (for notificationsCell):
            /*
            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += OnCellTapped;
            gridNotification.GestureRecognizers.Add(tapGesture);
            */

            // Set the TableView as the Content of your page
            Content = tableView;
        }


        private async void OnCellTapped(object sender, System.EventArgs e) {
            await DisplayAlert("Cell Tapped", "You tapped the notifications cell!", "OK");
        }
    }
}