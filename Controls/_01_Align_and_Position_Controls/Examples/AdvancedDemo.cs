using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Layouts;

namespace _01_Align_and_Position_Controls.Examples
{
    public class AdvancedDemo : ContentPage
    {
        public AdvancedDemo() {
            // Create a grid layout
            var grid = new Grid {
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Star }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Star }
                },
                BackgroundColor = Colors.LightGray,
                Margin = new Thickness(20)
            };

            // Add controls to the Grid
            var topLeftLabel = new Label {
                Text = "Top-Left",
                BackgroundColor = Colors.LightBlue,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            Grid.SetRow(topLeftLabel, 0);
            Grid.SetColumn(topLeftLabel, 0);

            var centerLabel = new Label {
                Text = "Center",
                BackgroundColor = Colors.LightGreen,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            Grid.SetRow(centerLabel, 1);
            Grid.SetColumn(centerLabel, 1);

            var bottomRightLabel = new Label {
                Text = "Bottom-Right",
                BackgroundColor = Colors.LightPink,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
            Grid.SetRow(bottomRightLabel, 2);
            Grid.SetColumn(bottomRightLabel, 2);


            // Add controls to the grid
            grid.Children.Add(topLeftLabel);
            grid.Children.Add(centerLabel);
            grid.Children.Add(bottomRightLabel);


            // Create a FlexLayout for dynamic alignment
            var flexLayout = new FlexLayout {
                Direction = FlexDirection.Row,
                JustifyContent = FlexJustify.SpaceAround,
                AlignItems = FlexAlignItems.Center,
                BackgroundColor = Colors.LightYellow,
                Margin = new Thickness(20),
                Padding = new Thickness(10),
                Children =
                {
                    new Label { Text = "Item 1", BackgroundColor = Colors.CornflowerBlue, HeightRequest = 50, WidthRequest = 100 },
                    new Label { Text = "Item 2", BackgroundColor = Colors.SkyBlue, HeightRequest = 50, WidthRequest = 100 },
                    new Label { Text = "Item 3", BackgroundColor = Colors.SteelBlue, HeightRequest = 50, WidthRequest = 100 },
                }
            };

            // Wrap everything in a vertical StackLayout
            var stackLayout = new StackLayout {
                Children = { grid, flexLayout },
                Spacing = 20
            };

            Content = stackLayout;
        }
    }
}