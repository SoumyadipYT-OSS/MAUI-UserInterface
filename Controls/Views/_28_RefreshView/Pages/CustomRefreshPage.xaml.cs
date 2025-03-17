using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;


namespace _28_RefreshView.Pages {

	public partial class CustomRefreshPage : ContentPage {
		public CustomRefreshPage() {
			InitializeComponent();
		}

		private async void OnRefresh(object sender, EventArgs e) {
			customIndicator.IsVisible = true;

			await Task.Delay(2000);

			customIndicator.IsVisible = false;
			customRefreshView.IsRefreshing = false;
		}
	}
}