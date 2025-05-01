using System.Diagnostics;

namespace Display_pop_ups
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void OnDisplayAlertClicked(object sender, EventArgs e) {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

        private async void OnBasicPopupClicked(object sender, EventArgs e) {
            bool ans = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            Debug.WriteLine("Answer: " + ans);

            if (ans)
                await DisplayAlert("Response", "Game is on!", "OK");
            else
                await DisplayAlert("Response", "Okay, see you next time", "OK");
        }

        private async void OnGuideUsersClicked(object sender, EventArgs e) {
            string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Dice");
            Debug.WriteLine($"{action}");

            if (action == "Email")
                await DisplayAlert("Email", "Opening email app...", "OK");
            else if (action == "Twitter")
                await DisplayAlert("Twitter", "Opening Twitter app...", "OK");
            else if (action == "Dice")
                await DisplayAlert("Dice", "Rolling the dice...", "OK");
            else
                await DisplayAlert("ActionSheet", "Cancelled", "OK");
        }

        private async void OnDisplayPromptClicked(object sender, EventArgs e) {
            string res = await DisplayPromptAsync("Queston 1", "What is your name?");
            Debug.WriteLine($"Name: {res}");
        }

        private async void OnDisplayPromptWithValueClicked(object sender, EventArgs e) {
            string res = await DisplayPromptAsync("Question 2", "What is your age?", "OK", "Cancel", "Enter your age", maxLength: 2, Microsoft.Maui.Keyboard.Numeric);
            Debug.WriteLine($"Age: {res}");
            if (int.TryParse(res, out int age)) {
                if (age < 18)
                    await DisplayAlert("Response", "You are not eligible for riding license", "OK");
                else
                    await DisplayAlert("Response", "You are eligible for riding license", "OK");
            }
        }
    }
}
