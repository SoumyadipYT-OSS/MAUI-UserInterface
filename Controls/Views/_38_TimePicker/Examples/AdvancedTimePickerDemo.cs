using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;


namespace _38_TimePicker.Examples {
    public class AdvancedTimePickerDemo : ContentPage {
        public AdvancedTimePickerDemo() {
            Title = "Advanced TimePicker";

            // Title Label
            var headerLabel = new Label {
                Text = "Custom Advanced TimePicker",
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.DarkSlateBlue,
                HorizontalOptions = LayoutOptions.Center
            };

            // Enhanced TimePicker with custom properties
            var customTimePicker = new TimePicker {
                Time = new TimeSpan(14, 30, 0), // Default time set to 2:30 PM
                Format = "HH:mm", // 24-hour format
                FontSize = 18,
                TextColor = Colors.DarkBlue,
                BackgroundColor = Colors.AliceBlue,
                HeightRequest = 50,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(20, 10)
            };

            // Label to display the selected time
            var timeDisplayLabel = new Label {
                Text = "Selected Time: ",
                FontSize = 20,
                TextColor = Colors.Black,
                HorizontalOptions = LayoutOptions.Center
            };

            // Add a button to confirm the time selection
            var confirmButton = new Button {
                Text = "Set Selected Time",
                BackgroundColor = Colors.SteelBlue,
                TextColor = Colors.White,
                CornerRadius = 10,
                FontSize = 18,
                HeightRequest = 50,
                WidthRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 20)
            };

            // Event handler for the TimePicker PropertyChanged
            customTimePicker.PropertyChanged += (sender, e) => {
                if (e.PropertyName == TimePicker.TimeProperty.PropertyName) {
                    var time = customTimePicker.Time;
                    timeDisplayLabel.Text = $"Selected Time: {time.Hours:D2}:{time.Minutes:D2}";
                }
            };

            // Event handler for the confirm button
            confirmButton.Clicked += (sender, e) => {
                var time = customTimePicker.Time;
                DisplayAlert("Time Confirmed", $"You selected {time.Hours:D2}:{time.Minutes:D2}", "OK");
            };

            // Organizing layout using a grid
            var gridLayout = new Grid {
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto }, // Header
                    new RowDefinition { Height = GridLength.Auto }, // TimePicker
                    new RowDefinition { Height = GridLength.Auto }, // Label
                    new RowDefinition { Height = GridLength.Auto }  // Button
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }
                },
                Padding = new Thickness(20)
            };


            // ========================
            // Adding views to the grid
            // ========================
             /*
                 -> headerLabel 
             */
            gridLayout.Children.Add(headerLabel);
            gridLayout.SetRow(headerLabel, 0);
            gridLayout.SetColumn(headerLabel, 0);
            /*
                 -> customTimePicker 
            */
            gridLayout.Children.Add(customTimePicker);
            gridLayout.SetRow(customTimePicker, 1);
            gridLayout.SetColumn(customTimePicker, 0);
            /*
                 -> timeDisplayLabel 
            */
            gridLayout.Children.Add(timeDisplayLabel);
            gridLayout.SetRow(timeDisplayLabel, 2);
            gridLayout.SetColumn(timeDisplayLabel, 0);
            /*
                 -> confirmButton
            */
            gridLayout.Children.Add(confirmButton);
            gridLayout.SetRow(confirmButton, 3);
            gridLayout.SetColumn(confirmButton, 0);


            // Set the page content
            Content = new ScrollView { Content = gridLayout };
        }
    }
}