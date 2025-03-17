using Microsoft.Maui.Controls;

namespace _37_TextCell.Examples
{
    public class BasicTextCell : ContentPage
    {
        public BasicTextCell() {
            Title = "TextCell Example";

            // Create TableView class
            var tableView = new TableView {
                Intent = TableIntent.Menu,      // Use as a menu or list
            };

            // Create TableRoot and TableSection
            var tableRoot = new TableRoot("TextCell Example") {
                new TableSection("Section 1") {
                    new TextCell {
                        Text = "TextCell 1",
                        Detail = "This is the details for TextCell 1"
                    },
                    new TextCell {
                        Text = "TextCell 2",
                        Detail = "This is the detail for TextCell 2",
                        TextColor = Microsoft.Maui.Graphics.Colors.SandyBrown,
                        DetailColor = Microsoft.Maui.Graphics.Colors.LightSkyBlue
                    }
                },

                new TableSection("Section 2")
                {
                    new TextCell
                    {
                        Text = "TextCell 3",
                        Detail = "This is the detail for TextCell 3",
                    },
                    new TextCell
                    {
                        Text = "TextCell 4",
                        Detail = "This is the detail for TextCell 4"
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