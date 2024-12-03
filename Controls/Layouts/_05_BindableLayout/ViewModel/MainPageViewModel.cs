using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace _05_BindableLayout.ViewModel {
    public class MainPageViewModel : BindableObject {
        public ObservableCollection<Item> Items { get; set; }
        public ObservableCollection<Student>? Students { get; set; }

        public MainPageViewModel() {
            Items = new ObservableCollection<Item> { 
                new() {Name = "Item 1"},
                new() {Name = "Item 2"},
                new() {Name = "Item 3"}
            };
            Students = new ObservableCollection<Student> {
                new() {Name = "Subhasis Majee", Age = 20, Grade = "AA" },
                new() {Name = "Dishant Yadav", Age = 19, Grade = "A+"},
                new() {Name = "Ashutosh Mahapatra", Age = 19, Grade = "AA+"},
                new() {Name = "Aparesh Kumar", Age = 19, Grade = "A+"},
            };
        }   
    }



    public class Item {
        public string? Name { get; set; }
    }

    public class Student {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Grade { get; set; }
    }
}
