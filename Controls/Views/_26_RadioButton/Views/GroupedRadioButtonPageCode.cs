using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace _26_RadioButton.Views
{
    public class GroupedRadioButtonPageCode : ContentPage
    {
        readonly Label? colorLabel;
        readonly Label? fruitLabel;


        public GroupedRadioButtonPageCode() {
            fruitLabel = new Label { Text = "You have chosen: " };
            colorLabel = new Label { Text = "You have chosen: " };

            RadioButton paleVioletRedRadioButton = new() { Content = "PaleVioletRed", TextColor = Colors.PaleVioletRed, GroupName = "colors" };
            paleVioletRedRadioButton.CheckedChanged += OnColorsRadioButtonCheckedChanged!;

            RadioButton oliveDrabRadioButton = new() { Content = "OliveDrab", TextColor = Colors.OliveDrab, GroupName = "colors" };
            oliveDrabRadioButton.CheckedChanged += OnColorsRadioButtonCheckedChanged!;

            RadioButton dodgerBlueRadioButton = new() { Content = "DodgerBlue", TextColor = Colors.DodgerBlue, GroupName = "colors" };
            dodgerBlueRadioButton.CheckedChanged += OnColorsRadioButtonCheckedChanged!;

            RadioButton otherColorRadioButton = new() { Content = "Other", GroupName = "colors" };
            otherColorRadioButton.CheckedChanged += OnColorsRadioButtonCheckedChanged!;


            RadioButton amlaRadioButton = new() { Content = "Amla" };
            amlaRadioButton.CheckedChanged += OnFruitsRadioButtonCheckedChanged!;

            RadioButton blueBerriesRadioButton = new() { Content = "Blue Berries" };
            blueBerriesRadioButton.CheckedChanged += OnFruitsRadioButtonCheckedChanged!;

            RadioButton papayaRadioButton = new() { Content = "Papaya" };
            papayaRadioButton.CheckedChanged += OnFruitsRadioButtonCheckedChanged!;

            RadioButton otherRadioButton = new() { Content = "Other" };
            otherRadioButton.CheckedChanged += OnFruitsRadioButtonCheckedChanged!;


            StackLayout fruitStackLayout = new() {
                Children = { amlaRadioButton, blueBerriesRadioButton, papayaRadioButton, otherRadioButton }
            };


            // All of the RadioButton in this StackLayout will automatically be given the GroupName 'fruits'.
            RadioButtonGroup.SetGroupName(fruitStackLayout, "fruits");


            /*
                We implement the interface 'ContentPage' it is built-in library interface,
                that will help us to implement 'Title, Content etc. such XAML property in C#'.
            */
            Title = "Grouped RadioButtons demo (code)";
            Content = new StackLayout {
                Margin = new Thickness(10),
                Padding = new Thickness(10),
                Children = {
                    new Label { Text = "What's your favourite color?" },
                    paleVioletRedRadioButton,
                    oliveDrabRadioButton,
                    dodgerBlueRadioButton,
                    otherColorRadioButton,
                    colorLabel,
                    new Label { Text = "What's your favorite fruit?" },
                    fruitStackLayout,
                    fruitLabel
                }
            };
        }


        void OnColorsRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e) {
            RadioButton? button = sender as RadioButton;
            colorLabel!.Text = $"You have chosen: {button!.Content}";
        }

        void OnFruitsRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e) {
            RadioButton? button = sender as RadioButton;
            fruitLabel!.Text = $"You have chosen: {button!.Content}";
        }
    }
}

