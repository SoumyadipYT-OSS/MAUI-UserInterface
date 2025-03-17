namespace _26_RadioButton.Views {

	public partial class GroupedRadioButtonsPage : ContentPage {
		public GroupedRadioButtonsPage() {
			InitializeComponent();
		}


		void OnColorsRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e) {
			Microsoft.Maui.Controls.RadioButton? button = sender as RadioButton;
			colorLabel.Text = $"Your choice: {button!.Content}";
		}

		void OnFruitsRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e) {
			Microsoft.Maui.Controls.RadioButton? button = sender as RadioButton;
			fruitLabel.Text = $"You have chosen: {button!.Content}";
		}
	}
}
