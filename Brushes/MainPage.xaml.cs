using Brushes.Views;

namespace Brushes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SolidColorBrush_Clicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new SolidColorBrushPage());
        }

        private async void LinearGradientBrush_Clicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new LinearGradientBrushPage());
        }

        private async void RadialGradientBrush_Clicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new RadialGradientBrushPage());
        }
    }
}
