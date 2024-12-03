using Microsoft.Maui.Controls;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05_BindableLayout.MyPackage {
    public class CustomDataGrid : Grid {
        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable), typeof(CustomDataGrid), propertyChanged: OnItemsSourceChanged);

        public IEnumerable ItemsSource {
            get => (IEnumerable)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue) {
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

            // Create columns
            foreach (var property in properties) {
                ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
                var headerLabel = new Label { Text = property.Name, FontAttributes = FontAttributes.Bold, BackgroundColor = Colors.LightGray, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
                Children.Add(headerLabel);
                SetColumn((BindableObject)headerLabel, ColumnDefinitions.Count - 1);
            }

            // Create rows
            for (int i = 0; i < items.Count; i++) {
                RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                var item = items[i];
                for (int j = 0; j < properties.Length; j++) {
                    var value = properties[j].GetValue(item)?.ToString();
                    var cellLabel = new Label { Text = value, BackgroundColor = i % 2 == 0 ? Colors.White : Colors.LightGray, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
                    Children.Add(cellLabel);
                    SetRow((BindableObject)cellLabel, i + 1);
                    SetColumn((BindableObject)cellLabel, j);
                }
            }
        }
    }
}
