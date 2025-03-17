using Microsoft.Maui.Controls;

namespace _10_ContentView {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
