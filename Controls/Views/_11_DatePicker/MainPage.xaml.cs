using myDatePicker = Microsoft.Maui.Controls.DatePicker;
using System.Timers;
using Microsoft.Maui.Dispatching;

namespace _11_DatePicker {
    public partial class MainPage : ContentPage {
        private readonly System.Timers.Timer timer;

        public MainPage() {
            InitializeComponent();

            // Set DatePicker properties
            datePicker.MinimumDate = DateTime.Now.AddYears(-5);
            datePicker.MaximumDate = DateTime.Now.AddYears(5);
            datePicker.Date = DateTime.Now;

            // Initialize and start the timer to update the current time label
            timer = new System.Timers.Timer(999.998); // Update every second
            timer.Elapsed += UpdateTime;
            timer.Start();
        }

        private void UpdateTime(object? sender, ElapsedEventArgs e) {
            // Ensure the update happens on the main thread
            MainThread.BeginInvokeOnMainThread(() => {
                currentTimeLabel.Text = DateTime.Now.ToString("F"); // Full date/time pattern
            });
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e) {
            DisplayAlert("Date Selected", $"You selected {e.NewDate:D}", "OK");
        }

        private void SetToCurrentDate(object? sender, EventArgs e) {
            DateTime currDate = DateTime.Now;
            if (datePicker.Date != currDate) {
                datePicker.Date = currDate;
            }
        }
    }
}
