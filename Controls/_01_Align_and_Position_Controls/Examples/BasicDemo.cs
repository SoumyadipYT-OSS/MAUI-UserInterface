using Microsoft.Maui.Controls;

namespace _01_Align_and_Position_Controls.Examples
{
    public class BasicDemo : ContentPage
    {
        public BasicDemo() {
            // Create controls
            var label1 = new Label {
                Text = "Top Start",
                BackgroundColor = Colors.LightBlue,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start
            };

            var label2 = new Label {
                Text = "Center",
                BackgroundColor = Colors.LightGreen,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            var label3 = new Label {
                Text = "Bottom End",
                BackgroundColor = Colors.LightPink,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End
            };

            // Create layout
            var stackLayout = new StackLayout {
                Children = { label1, label2, label3 },
                BackgroundColor = Colors.LightGray,
                Margin = new Thickness(20),
                Padding = new Thickness(10)
            };

            // Set the layout as the content of the page
            Content = stackLayout;
        }
    }
}