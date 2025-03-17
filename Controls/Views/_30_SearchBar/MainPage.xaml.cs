using Microsoft.Maui.Controls;

namespace _30_SearchBar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listView.ItemsSource = GetItems();
        }


        private List<string> GetItems() {
            return new List<string> { "Apple", "Banana", "Cherry", "Dates", "Watermelon", "Guava" };
        }

        private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e) {
            listView.ItemsSource = GetItems().Where(item => item.ToLower().Contains(e.NewTextValue.ToLower()));
        }

        private void OnSearchBarButtonPressed(object sender, EventArgs e) {
            DisplayAlert("Search", "You searched for: " + searchBar.Text, "OK");
        }
    }

}
