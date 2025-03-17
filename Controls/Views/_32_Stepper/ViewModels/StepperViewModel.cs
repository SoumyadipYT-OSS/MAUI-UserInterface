using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _32_Stepper.ViewModels
{
    public class StepperViewModel : INotifyPropertyChanged
    {
        private double _stepperValue;
        public double StepperValue {
            get => _stepperValue;
            set {
                if (_stepperValue != value) {
                    _stepperValue = value;
                    OnPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
