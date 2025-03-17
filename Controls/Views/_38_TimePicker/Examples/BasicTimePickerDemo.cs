using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace _38_TimePicker.Examples {
    public class BasicTimePickerDemo : ContentPage {
        private readonly TimePicker timePicker;
        private readonly Label outputLabel;

        public BasicTimePickerDemo() {
            timePicker = new TimePicker {
                Time = new TimeSpan(12, 0, 0)
            };

            outputLabel = new Label {
                Text = "Select a time:"
            };

            timePicker.PropertyChanged += TimePicker_PropertyChanged;

            var grid = new Grid {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            grid.Children.Add(outputLabel);
            Grid.SetRow(outputLabel, 0);

            grid.Children.Add(timePicker);
            Grid.SetRow(timePicker, 1);

            Content = grid;
        }

        private void TimePicker_PropertyChanged(object? sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName) {
                var time = timePicker.Time;
                outputLabel.Text = $"Time is {time.Hours:D2}:{time.Minutes:D2}";
            }
        }
    }
}