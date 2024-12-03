using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace _05_BindableLayout.ViewModel {
    public class MainPageViewModel : BindableObject {
        public ObservableCollection<Item> Items { get; set; }

        public MainPageViewModel() {
            Items = new ObservableCollection<Item> { 
                new() {Name = "Item 1"},
                new() {Name = "Item 2"},
                new() {Name = "Item 3"}
            };
        }
    }

    public class Item {
        public string? Name { get; set; }
    }
}
