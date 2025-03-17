using Microsoft.Maui.Controls;

namespace _34_Switch
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void OnSwitchToggled(object sender, ToggledEventArgs e) {
            DisplayAlert("Switch Toggled", $"Switch is now {(e.Value ? "On" : "Off")}", "OK");
        }

        private void OnToggled(object sender, ToggledEventArgs e) {
            bool isNightMode = e.Value;

            if (isNightMode) {
                boxView.Style = (Style)Application.Current!.Resources["NightModeBoxView"];
                label.Style = (Style)Application.Current.Resources["NightModeLabel"];
            } else {
                boxView.Style = (Style)Application.Current!.Resources["DayModeBoxView"];
                label.Style = (Style)Application.Current.Resources["DayModeLabel"];
            }
        }
    }
}