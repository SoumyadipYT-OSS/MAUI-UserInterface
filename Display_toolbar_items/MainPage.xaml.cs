namespace Display_toolbar_items
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e) {
            await DisplayAlert("Save", "Save clicked", "OK");
        }

        private async void OnSettingsClicked(object sender, EventArgs e) {
            await DisplayAlert("Settings", "Settings clicked", "OK");
        }
    }

}
