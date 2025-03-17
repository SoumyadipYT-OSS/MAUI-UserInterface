using Microsoft.Maui.Controls;

namespace _38_TimePicker.Examples {

	public partial class BasicTimePicker : ContentPage {
		public BasicTimePicker() {
			InitializeComponent();
            timePicker.PropertyChanged += TimePicker_PropertyChanged!;
		}

		private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName) {
                var time = timePicker.Time;
                outputLabel.Text = $"Time is {time.Hours:D2}:{time.Minutes:D2}";
            }
        }
    }
}