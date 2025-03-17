using _30_SearchBar.ViewModels;
using Microsoft.Maui.Controls;

namespace _30_SearchBar.Pages {

	public partial class AdvancedSearchBar : ContentPage {
		public AdvancedSearchBar() {
			InitializeComponent();
		}

		private void OnSuggestionSelected(object sender, SelectionChangedEventArgs e) {
			if (e.CurrentSelection.Count > 0) {
				var selectedItem = e.CurrentSelection.FirstOrDefault()!.ToString();
				var viewModel = BindingContext as AdvancedSearchViewModel;
				if (viewModel != null) {
					viewModel.SearchQuery = selectedItem!;
					viewModel.Suggestions.Clear();
				}
			}
		}
	}
}