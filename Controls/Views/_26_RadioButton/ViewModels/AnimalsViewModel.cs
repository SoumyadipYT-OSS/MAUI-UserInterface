using System.ComponentModel;

namespace _26_RadioButton.ViewModels
{
    public class AnimalsViewModel : INotifyPropertyChanged
    {
        string? groupName;
        object? selection;

        public string GroupName {
            get => groupName!;
            set {
                groupName = value;
                OnPropertyChanged(nameof(GroupName));
            }
        }

        public object Selection {
            get => selection!;
            set {
                selection = value;
                OnPropertyChanged(nameof(Selection));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
