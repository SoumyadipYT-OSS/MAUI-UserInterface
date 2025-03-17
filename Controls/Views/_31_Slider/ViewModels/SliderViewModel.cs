using System.ComponentModel;
using Microsoft.Maui.Controls;

namespace _31_Slider.ViewModels
{
    public class SliderViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private double sliderValue;

        public double SliderValue {
            get => sliderValue;
            set {
                if (sliderValue != value) {
                    sliderValue = value;
                    OnPropertyChanged(nameof(SliderValue));
                }
            }
        }


        protected void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}