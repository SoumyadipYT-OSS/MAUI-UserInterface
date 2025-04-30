using Animation.Views;

namespace Animation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnBasicAnimationClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new Views.BasicAnimationPage());
        }

        private async void OnEasingFunctionClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new Views.EasingFunction());
        }

        private async void OnCustomAnimationClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new Views.CustomAnimation());
        }
    }

}
