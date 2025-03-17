using Microsoft.Maui.Controls;

namespace _26_RadioButton.Views 
{
	public partial class BasicRadioButtonsPage : ContentPage {
		public BasicRadioButtonsPage() {
			InitializeComponent();
		}


		void OnAnimalRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e) {
			RadioButton? button = sender as RadioButton;
			animalLabel.Text = $"Your choice: {button!.Content}";
		}

		void OnAnimalImageRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e) {
			RadioButton? button = sender as RadioButton;
            string animal = button?.Content?.ToString() ?? string.Empty;

            animalImageLabel.Text = $"Your choice: {animal}";

            // Log animal selected
            System.Diagnostics.Debug.WriteLine($"Selected Animal: {animal}");

            ImageLabel.Source = animal switch {
                "Elephant" => (ImageSource)"elephant.png",
                "Koala" => (ImageSource)"koala.png",
                "Monkey" => (ImageSource)"monkey.png",
                "Squirrell" => (ImageSource)"squirrell.png",
                _ => null,
            };

            // Log image source updated
            System.Diagnostics.Debug.WriteLine($"Image Source: {ImageLabel.Source}");
        }
	}
}
