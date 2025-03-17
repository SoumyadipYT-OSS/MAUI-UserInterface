namespace _25_ProgressBar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnUpdateProgressClicked(object? sender, EventArgs e) {
            if (double.TryParse(progressEntry.Text, out double inputProgress) && inputProgress >= 0  &&  inputProgress <= 100) {
                double progress = inputProgress / 100;      // Convert the value between 0 and 1
                await Ex3PB.ProgressTo(/*local var*/ progress, /* time: 32 bit int*/ 500, /*built-in ease function*/ Easing.Linear);
            } else {
                await DisplayAlert("Invalid Input", "Please enter a valid number between 0 and 100.", "OK");
            }
        }
    }
}
