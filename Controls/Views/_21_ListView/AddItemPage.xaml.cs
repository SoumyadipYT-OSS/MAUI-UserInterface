using _21_ListView.Model;
using _21_ListView.ViewModel;
using Microsoft.Maui.Controls;
using System;


namespace _21_ListView {

	public partial class AddItemPage : ContentPage {

		public AddItemPage() {
			InitializeComponent();
			BindingContext = App.MVM;
		}



		private void OnAddItemCliecked(object? sender, EventArgs e) {
			// Input Validation
			if (string.IsNullOrWhiteSpace(NameEntry.Text) ||
                string.IsNullOrWhiteSpace(DescriptionEntry.Text) ||
                string.IsNullOrWhiteSpace(QtyEntry.Text) ||
                string.IsNullOrWhiteSpace(ImgUrlEntry?.Text) ||
                string.IsNullOrWhiteSpace(PriceEntry.Text)) {
				DisplayAlert("Validation Error", "Please fill in all fields.", "OK");
				return;
			}


			if (!int.TryParse(QtyEntry.Text, out int quantity) || !decimal.TryParse(PriceEntry.Text, out decimal price)) {
				DisplayAlert("Validation Error", "Quantity and Price must be numeric.", "OK");
				return;
			}

			var imageUrl = ImgUrlEntry?.Text ?? string.Empty;

			var newItem = new GroceryItem {
				Name = NameEntry.Text,
				Description = DescriptionEntry.Text,
				Quantity = quantity,
#pragma warning disable CS8601
				ImageUrl = string.IsNullOrWhiteSpace(imageUrl) ? null : imageUrl,
#pragma warning restore CS8601
				Price = price
			};

			App.MVM!.GI!.Add(newItem);

			DisplayAlert("Success", "Item added successfully!", "OK");

			// Clear input fields
			NameEntry.Text = string.Empty;
			DescriptionEntry.Text = string.Empty;
			QtyEntry.Text = string.Empty;
			ImgUrlEntry!.Text = string.Empty;
			PriceEntry.Text = string.Empty;
		}



		private void OnDeleteItemClicked(object? sender, EventArgs e) {
            if ((sender as Button)!.CommandParameter is GroceryItem itemToDelete) {
				App.MVM!.GI!.Remove(itemToDelete);
				DisplayAlert("Success", "Item deleted successfully!", "OK");
            }
        }

		private async void OnEditItemClicked(object? sender, EventArgs e) {
            if ((sender as Button)!.CommandParameter is GroceryItem itemToEdit) {
                await Navigation.PushAsync(new EditPage(itemToEdit));
            }
        }

		private async void OnFinalizeClicked(object? sender, EventArgs e) {
            // Save the list - in this case, the list is already updated in the ViewModel, which is shared.

            await DisplayAlert("Success", "List finalized and saved!", "OK");
            await Navigation.PopAsync();
        }
    }
}
