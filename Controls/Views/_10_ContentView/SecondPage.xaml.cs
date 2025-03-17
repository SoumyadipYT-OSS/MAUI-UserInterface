using Microsoft.Maui.Controls;

namespace _10_ContentView {
    public partial class SecondPage : ContentPage {
        public SecondPage() {
            InitializeComponent();
        }

        private async void OnGoBackButtonClicked(object sender, EventArgs e) {
            await Navigation.PopAsync();
        }
    }
}
