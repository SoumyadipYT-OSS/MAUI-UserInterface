namespace _26_RadioButton.Views;

public partial class BasicRadioButtonsVisualStatePage : ContentPage
{
	public BasicRadioButtonsVisualStatePage()
	{
		InitializeComponent();
	}

	void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e) {
		Microsoft.Maui.Controls.RadioButton? button = sender as Microsoft.Maui.Controls.RadioButton;
		resultLabel.Text = $"Your choice: {button!.Content}";
	}
}