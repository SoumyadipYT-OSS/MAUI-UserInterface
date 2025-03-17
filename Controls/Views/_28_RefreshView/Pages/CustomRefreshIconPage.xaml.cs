using System.Threading.Tasks;
using Microsoft.Maui.Controls;


namespace _28_RefreshView.Pages {

	public partial class CustomRefreshIconPage : ContentPage {
		public CustomRefreshIconPage() {
			InitializeComponent();
		}

		private async void OnRefresh(object sender, System.EventArgs e) {
			customIconIndicator.IsVisible = true;

			var animationTask = AnimateIcon();

			await Task.Delay(2000);

			customIconRefreshView.IsRefreshing = false;

			customIconIndicator.IsVisible = false;

			await animationTask;
		}


		private async Task AnimateIcon() {
			while (customIconIndicator.IsVisible) {
				await refreshIconImage.RelRotateTo(360, 100, Easing.Linear);
			}

			refreshIconImage.Rotation = 0;
		}
	}
}