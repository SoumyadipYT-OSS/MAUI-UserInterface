using _21_ListView.Model;
using Microsoft.Maui.Controls;

namespace _21_ListView {

	public partial class EditPage : ContentPage {
		private readonly GroceryItem Items;

		public EditPage(GroceryItem Items) {
			InitializeComponent();
			this.Items = Items;
			BindingContext = Items;
		}


		private async void OnSaveClicked(object? sender, EventArgs e) {
			await Navigation.PopAsync();
		}

		private async void OnCancelClicked(object? sender, EventArgs e) {
			await Navigation.PopAsync();
		}
	}
}