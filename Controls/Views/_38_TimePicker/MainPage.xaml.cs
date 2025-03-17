using Microsoft.Maui.Controls;

namespace _38_TimePicker {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            // Initialize the time label with the default TimePicker value
            var time = customTimePicker.Time;
            timeLabel.Text = $"Selected Time: {time.Hours:D2}:{time.Minutes:D2}";

            // Add PropertyChanged event handler for TimePicker
            customTimePicker.PropertyChanged += CustomTimePicker_PropertyChanged!;
        }

        // Event to handle changes in TimePicker's Time property
        private void CustomTimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName) {
                var time = customTimePicker.Time;
                timeLabel.Text = $"Selected Time: {time.Hours:D2}:{time.Minutes:D2}";
            }
        }

        // Event handler for the button's Clicked event
        private void OnConfirmTimeClicked(object sender, EventArgs e) {
            var selectedTime = customTimePicker.Time; // Access the selected time from the TimePicker
            DisplayAlert("Time Confirmed", $"You selected {selectedTime.Hours:D2}:{selectedTime.Minutes:D2}", "OK");
        }
    }
}