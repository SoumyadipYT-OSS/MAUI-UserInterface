using Microsoft.Maui.Controls;

namespace _37_TextCell.Examples {
    public class AdvancedTextCell : ContentPage {
        public AdvancedTextCell() {
            Title = "Advanced TextCell Example";

            // Create TableView class
            var tableView = new TableView {
                Intent = TableIntent.Menu, // Use as a menu or list
            };

            // Create TableRoot and TableSection
            var tableRoot = new TableRoot("Advanced TextCell Example")
            {
                new TableSection("Section 1")
                {
                    new TextCell
                    {
                        Text = "Advanced TextCell 1",
                        Detail = "This is the detail for Advanced TextCell 1",
                        TextColor = Microsoft.Maui.Graphics.Colors.DarkBlue,
                        DetailColor = Microsoft.Maui.Graphics.Colors.Gray,
                        Command = new Command(() => DisplayAlert("Alert", "Advanced TextCell 1 tapped", "OK")),
                        CommandParameter = "Advanced TextCell 1"
                    },
                    new TextCell
                    {
                        Text = "Advanced TextCell 2",
                        Detail = "This is the detail for Advanced TextCell 2",
                        TextColor = Microsoft.Maui.Graphics.Colors.DarkGreen,
                        DetailColor = Microsoft.Maui.Graphics.Colors.Gray,
                        Command = new Command(() => DisplayAlert("Alert", "Advanced TextCell 2 tapped", "OK")),
                        CommandParameter = "Advanced TextCell 2"
                    }
                },

                new TableSection("Section 2")
                {
                    new TextCell
                    {
                        Text = "Advanced TextCell 3",
                        Detail = "This is the detail for Advanced TextCell 3",
                        TextColor = Microsoft.Maui.Graphics.Colors.DarkRed,
                        DetailColor = Microsoft.Maui.Graphics.Colors.Gray,
                        Command = new Command(() => DisplayAlert("Alert", "Advanced TextCell 3 tapped", "OK")),
                        CommandParameter = "Advanced TextCell 3"
                    },
                    new TextCell
                    {
                        Text = "Advanced TextCell 4",
                        Detail = "This is the detail for Advanced TextCell 4",
                        TextColor = Microsoft.Maui.Graphics.Colors.DarkOrange,
                        DetailColor = Microsoft.Maui.Graphics.Colors.Gray,
                        Command = new Command(() => DisplayAlert("Alert", "Advanced TextCell 4 tapped", "OK")),
                        CommandParameter = "Advanced TextCell 4"
                    }
                }
            };

            // Assign the TableRoot to the TableView
            tableView.Root = tableRoot;

            // Set the TableView as the Content of the page
            Content = tableView;
        }
    }
}