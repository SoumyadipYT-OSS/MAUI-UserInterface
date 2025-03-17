using Microsoft.Maui.Controls;

namespace _26_RadioButton.Views;

public partial class RadioButtonControlTemplatePage : ContentPage
{
	public RadioButtonControlTemplatePage()
	{
		InitializeComponent();
	}

	void OnAnimalRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e) {
		RadioButton? button = sender as RadioButton;
		animalLabel.Text = $"Your choice: {button!.Value}";
	}
}