using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _21_ListView.Model {
    public class GroceryItem : INotifyPropertyChanged {
        private string? name;
        private string? description;
        private int quantity;
        private string? imageUrl;
        private decimal price;

        public string Name {
            get => name!;
            set {
                if (name != value) {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Description {
            get => description!;
            set {
                if (description != value) {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Quantity {
            get => quantity;
            set {
                if (quantity != value) {
                    quantity = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ImageUrl {
            get => imageUrl!;
            set {
                if (imageUrl != value) {
                    imageUrl = value;
                    OnPropertyChanged();
                }
            }
        }

        public decimal Price {
            get => price;
            set {
                if (price != value) {
                    price = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
