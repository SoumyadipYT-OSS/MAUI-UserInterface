using Microsoft.Maui.Controls;
using _32_Stepper.ViewModels;

namespace _32_Stepper
{
    public partial class MainPage : ContentPage
    {
        StepperViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new StepperViewModel();
            BindingContext = viewModel;
        }


        void OnStepperValueChanged(object sender, ValueChangedEventArgs e) {
            double rotation = e.NewValue;
            _rotatingLabel.Rotation = rotation;
            viewModel.StepperValue = rotation;
        }
    }
}