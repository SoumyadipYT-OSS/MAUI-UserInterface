using System.ComponentModel;

namespace _08_CheckBoxClass {
    public partial class MainPage : ContentPage, INotifyPropertyChanged {
        private bool isChecked;
        public string CheckBoxStatus => IsChecked ? "Checked" : "Unchecked";

        public bool IsChecked {
            get => isChecked;
            set {
                if (isChecked != value) {
                    isChecked = value;
                    OnPropertyChanged(nameof(IsChecked));
                    OnPropertyChanged(nameof(CheckBoxStatus));
                }
            }
        }

        public MainPage() {
            InitializeComponent();
            IsChecked = false;
            BindingContext = this;
        }
        

        public new event PropertyChangedEventHandler? PropertyChanged;

        protected virtual new void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}