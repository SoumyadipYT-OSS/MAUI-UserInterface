using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _33_SwipeView.Models
{
    public class TaskModel : INotifyPropertyChanged
    {
        private string? name;
        public string Name {
            get => name!;
            set {
                if (name != value) {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool isCompleted;
        public bool IsCompleted {
            get => isCompleted;
            set {
                if (isCompleted != value) {
                    isCompleted = value;
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