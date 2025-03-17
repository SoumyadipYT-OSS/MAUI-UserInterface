using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace _30_SearchBar.ViewModels
{
    public class AdvancedSearchViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string? searchQuery;

        public string SearchQuery {
            get => searchQuery!;
            set {
                if (searchQuery != value) {
                    searchQuery = value;
                    OnPropertyChanged(nameof(SearchQuery));
                    FilterItems();
                }
            }
        }



        public ObservableCollection<string> Items { get; set; }
        public ObservableCollection<string> Suggestions { get; set; }
        public ICommand SearchCommand { get; set; }

        public AdvancedSearchViewModel() {
            Items = [.. GetItems()];
            Suggestions = [];
            SearchCommand = new Command(FilterItems);
        }

        private List<string>  GetItems() {
            return ["Apple", "Banana", "Cherry", "Date", "Fig", "Grape", "Honeydew", "Kiwi", "Lemon", "Mango"];
        }

        private void FilterItems() {
            var filteredItems = GetItems().Where(item => item.ToLower().Contains(SearchQuery?.ToLower() ?? string.Empty)).ToList();
            Items.Clear();
            Suggestions.Clear();
            foreach (var item in filteredItems) {
                Items.Add(item);
                if (!string.IsNullOrEmpty(SearchQuery)) {
                    Suggestions.Add(item);
                }
            }
        }



        protected void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
