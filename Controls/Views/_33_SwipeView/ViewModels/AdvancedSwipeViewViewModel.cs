using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using _33_SwipeView.Models;
using Microsoft.Maui.Controls;

namespace _33_SwipeView.ViewModels
{
    public class AdvancedSwipeViewViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TaskModel> Tasks { get; set; }

        public ICommand CompleteTaskCommand { get; }
        public ICommand EditTaskCommand { get; }
        public ICommand DeleteTaskCommand { get; }

        public AdvancedSwipeViewViewModel() {
            Tasks = [
                new() { Name = "Buy Groceries", IsCompleted = false },
                new() { Name = "Call .NET MAUI", IsCompleted = true },
                new() { Name = "Complete Project", IsCompleted = true }
            ];

            CompleteTaskCommand = new Command<TaskModel>(OnCompleteTask);
            EditTaskCommand = new Command<TaskModel>(OnEditTask);
            DeleteTaskCommand = new Command<TaskModel>(OnDeleteTask);
        }

        void OnCompleteTask(TaskModel task) {
            if (task != null) {
                task.IsCompleted = true;
                OnPropertyChanged(nameof(Tasks));
            }
        }

        void OnEditTask(TaskModel task) {
            if (task != null) {
                task.Name = $"{task.Name} (Edited)";
                OnPropertyChanged(nameof(Tasks));
            }
        }

        void OnDeleteTask(TaskModel task) {
            if (task != null) {
                Tasks.Remove(task);
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyname = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}