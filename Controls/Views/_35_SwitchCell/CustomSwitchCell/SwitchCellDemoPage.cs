using System;
using Microsoft.Maui.Controls;

namespace _35_SwitchCell.CustomSwitchCell
{
    public class SwitchCellDemoPage : ContentPage
    {
        public SwitchCellDemoPage() {
            Label header = new() {
                Text = "SwitchCell Demo",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Center
            };

            // Create a SwitchCell
            SwitchCell switchCell = new() {
                Text = "Enable Feature:"
            };

            // Handle the OnChanged event
            switchCell.OnChanged += (sender, e) => {
                DisplayAlert("Switch Toggled", $"Switch is now {(e.Value ? "On" : "Off")}", "OK");
            };

            // Create a TableView and add the SwitchCell
            TableView tableView = new() {
                Intent = TableIntent.Form,
                Root =
                [
                    [
                        switchCell
                    ]
                ]
            };

            // Accommodate iPhone status bar.
            this.Padding = new Thickness(10, DeviceInfo.Platform == DevicePlatform.iOS ? 20: 0, 10, 5);

            // Build the page.
            this.Content = new StackLayout {
                Children =
                {
                    header, tableView
                }
            };
        }
    }
}