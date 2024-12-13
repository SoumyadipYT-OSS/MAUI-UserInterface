using Microsoft.Maui.Controls;

namespace _05_Button {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            AnimateButton();
        }

        private void OnButtonClicked(object sender, EventArgs e) {
            // Handle the button click event
            DisplayAlert("Button Clicked", "You clicked the button!", "OK");
        }
        private async void OnButtonFontAtrribute(object sender, EventArgs e) {
            colorChangingButton.BackgroundColor = Colors.Green;
            await DisplayAlert("Button Clicked!", "You clicked the button!", "OK");
        }

        private async void AnimateButton() {
            while (true) {
                await animatedButton.ScaleTo(1.2, 500);
                await animatedButton.ScaleTo(1.0, 500);
            }
        }
    }
}