using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;


namespace _28_RefreshView.Pages {

	public partial class CustomDesignRefreshPage : ContentPage {
		public CustomDesignRefreshPage() {
			InitializeComponent();
		}

#if IOS
		private async void OnRefresh(object sender, EventArgs e) {
			customStrokeOverlay.IsVisible = true;
			strokeIndicator.Animate();

			await Task.Delay(2000);

			customStrokeRefreshPage.IsRefreshing = false;

			strokeIndicator.StopAnimation();
			customStrokeOverlay.IsVisible = false;
		}
#else
        private async void OnRefresh(object sender, EventArgs e) {
            customStrokeOverlay.IsVisible = true;
            strokeIndicator.Animate();

            await Task.Delay(2000);

            customStrokeRefreshPage.IsRefreshing = false;

            strokeIndicator.StopAnimation();
            customStrokeOverlay.IsVisible = false;
        }
#endif
	}
}