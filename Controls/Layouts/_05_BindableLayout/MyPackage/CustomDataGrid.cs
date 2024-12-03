using Microsoft.Maui.Controls;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05_BindableLayout.MyPackage {
    public class CustomDataGrid : Grid {
        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable), typeof(CustomDataGrid), propertyChanged: OnItemsSourceChanged);

        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(nameof(FontSize), typeof(double), typeof(CustomDataGrid), 14.0, propertyChanged: OnFontSizeChanged);

        public static readonly BindableProperty HeaderNamesProperty =
            BindableProperty.Create(nameof(HeaderNames), typeof(IEnumerable<string>), typeof(CustomDataGrid), default(IEnumerable<string>), propertyChanged: OnHeaderNamesChanged);

        public IEnumerable ItemsSource {
            get => (IEnumerable)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public double FontSize {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        public IEnumerable<string> HeaderNames {
            get => (IEnumerable<string>)GetValue(HeaderNamesProperty);
            set => SetValue(HeaderNamesProperty, value);
        }

        private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue) {
            var control = (CustomDataGrid)bindable;
            control.PopulateGrid();
        }

        private static void OnFontSizeChanged(BindableObject bindable, object oldValue, object newValue) {
            var control = (CustomDataGrid)bindable;
            control.PopulateGrid();
        }

        private static void OnHeaderNamesChanged(BindableObject bindable, object oldValue, object newValue) {
            var control = (CustomDataGrid)bindable;
            control.PopulateGrid();
        }

        private void PopulateGrid() {
            Children.Clear();
            RowDefinitions.Clear();
            ColumnDefinitions.Clear();

            if (ItemsSource == null) return;

            var items = ItemsSource.Cast<object>().ToList();
            if (!items.Any()) return;

            // Assuming the first item defines the columns
            var firstItem = items.First();
            var properties = firstItem.GetType().GetProperties();


            // Create headers
            var headerNames = HeaderNames?.ToList() ?? new List<string>();
            for (int i=0; i<properties.Length; i++) {
                var headerName = headerNames.Count > i ? headerNames[i] : $"header{i + 1:00}";
                ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                var cellHeader = new Label {
                    Text = headerName,
                    FontAttributes = FontAttributes.Bold,
                    BackgroundColor = Colors.LightBlue,
                    HorizontalOptions = LayoutOptions.Fill,
                    VerticalOptions = LayoutOptions.Fill,
                    Padding = new Thickness(FontSize / 2)
                };
                var headerBorder = new Border {
                    Stroke = Colors.Black,
                    StrokeThickness = 1,
                    Content = cellHeader
                };
                Children.Add(headerBorder);
                SetColumn((BindableObject)headerBorder, i);
            }



            
            // Create rows
            for (int i = 0; i < items.Count; i++) {
                RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                var item = items[i];
                for (int j = 0; j < properties.Length; j++) {
                    var value = properties[j].GetValue(item)?.ToString();
                    var cellLabel = new Label {
                        Text = value,
                        FontSize = FontSize,
                        BackgroundColor = (i % 2 == 0) ? Colors.White : Colors.LightSkyBlue,
                        HorizontalOptions = LayoutOptions.Fill,
                        VerticalOptions = LayoutOptions.Fill,
                        Padding = new Thickness(FontSize / 2)
                    };
                    var cellBorder = new Border {
                        Stroke = Colors.BlueViolet,
                        StrokeThickness = 1,
                        Content = cellLabel
                    };
                    Children.Add(cellBorder);
                    SetRow((BindableObject)cellBorder, i);
                    SetColumn((BindableObject)cellBorder, j);
                }
            }
        }
    }
}