using System.Collections.Generic;
using System.ComponentModel;

namespace _24_Picker.ViewModel
{
    public class MonkeyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private List<string> _monkeys = [];     // Ensure _monkeys is initialized.
        public List<string> Monkeys {
            get => _monkeys; 
            set {
                _monkeys = value;
                OnPropertyChanged(nameof(Monkeys));
            }
        }

        public MonkeyViewModel() {
            Monkeys = [
                "Baboon",
                "Capuchin Monkey",
                "Blue Monkey",
                "Squirrel Monkey",
                "Golden Lion Tamarin",
                "Howler Monkey",
                "Japanese Macaque"
            ];
        }

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private string? _selectedMonkey;
        public string? SelectedMonkey {
            get => _selectedMonkey;
            set {
                _selectedMonkey = value;
                OnPropertyChanged(nameof(SelectedMonkey));
            }
        }
    }
}
