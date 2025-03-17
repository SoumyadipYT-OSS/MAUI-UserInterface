using Microsoft.Maui.Controls;

namespace _38_TimePicker.Examples {
    public partial class AdvancedTimePicker : ContentPage {
        public AdvancedTimePicker() {
            InitializeComponent();

            // Set default time in the label
            var time = timePicker.Time;
            selectedTimeLabel.Text = $"Selected Time: {time.Hours:D2}:{time.Minutes:D2}";

            // Add PropertyChanged event handler for TimePicker
            timePicker.PropertyChanged += TimePicker_PropertyChanged!;
        }

        // Event to handle changes in TimePicker's time
        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName) {
                var time = timePicker.Time;
                selectedTimeLabel.Text = $"Selected Time: {time.Hours:D2}:{time.Minutes:D2}";
            }
        }

        private void OnConfirmTimeClicked(object sender, EventArgs e) {
            // Display an alert with the confirmed time
            var time = timePicker.Time;
            DisplayAlert("Time Confirmed", $"You selected {time.Hours:D2}:{time.Minutes:D2}", "OK");
        }
    }
}