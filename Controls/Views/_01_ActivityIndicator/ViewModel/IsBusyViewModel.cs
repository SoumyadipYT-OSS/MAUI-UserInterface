using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace _01_ActivityIndicator.ViewModel {
    public class IsBusyViewModel : INotifyPropertyChanged {
        private bool isBusy;

        public bool IsBusy {
            get => isBusy;
            set {
                if (isBusy != value) {
                    isBusy = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand? StartTaskCommand { get; }

        public IsBusyViewModel() {
            StartTaskCommand = new Command(StartTask);
        }


        private async void StartTask() {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}