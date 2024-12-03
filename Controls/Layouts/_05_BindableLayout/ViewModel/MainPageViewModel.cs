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
                new() {Name = "Subhasis Majee", Age = 20, Grade = "AA", Branch = "CS-IT", Regd_No = 123456789, Section = 'B' },
                new() {Name = "Dishant Yadav", Age = 19, Grade = "A+", Branch = "CS-IT", Regd_No = 123456789, Section = 'L' },
                new() {Name = "Ashutosh Mahapatra", Age = 19, Grade = "AA+", Branch = "CS-IT", Regd_No = 123456789, Section = 'K' },
                new() {Name = "Aparesh Kumar", Age = 19, Grade = "A+", Branch = "CS-IT", Regd_No = 123456789, Section = 'K' },
                new() {Name = "Rohit Sharma", Age = 20, Grade = "A", Branch = "Mechanical", Regd_No = 123456789, Section = 'A' },
                new() {Name = "Priya Singh", Age = 19, Grade = "B+", Branch = "Electrical", Regd_No = 123456789, Section = 'C' },
                new() {Name = "Anjali Verma", Age = 20, Grade = "A+", Branch = "Civil", Regd_No = 123456789, Section = 'D' },
                new() {Name = "Vikram Patel", Age = 21, Grade = "B", Branch = "Electronics", Regd_No = 123456789, Section = 'E' },
                new() {Name = "Sneha Das", Age = 19, Grade = "AA", Branch = "Computer Science", Regd_No = 123456789, Section = 'F' },
                new() {Name = "Amit Kumar", Age = 20, Grade = "A+", Branch = "Information Technology", Regd_No = 123456789, Section = 'G' },
                new() {Name = "Ritu Raj", Age = 21, Grade = "B+", Branch = "Mechanical", Regd_No = 123456789, Section = 'H' },
                new() {Name = "Kavita Sharma", Age = 19, Grade = "A", Branch = "Civil", Regd_No = 123456789, Section = 'I' },
                new() {Name = "Manish Gupta", Age = 20, Grade = "AA+", Branch = "Electrical", Regd_No = 123456789, Section = 'J' },
                new() {Name = "Pooja Rani", Age = 19, Grade = "B", Branch = "Electronics", Regd_No = 123456789, Section = 'M' },
                new() {Name = "Sanjay Mehta", Age = 20, Grade = "B+", Branch = "Mechanical", Regd_No = 123456789, Section = 'N' },
                new() {Name = "Rina Patel", Age = 19, Grade = "A", Branch = "Electrical", Regd_No = 123456789, Section = 'O' },
                new() {Name = "Arjun Singh", Age = 21, Grade = "AA", Branch = "Civil", Regd_No = 123456789, Section = 'P' },
                new() {Name = "Meera Nair", Age = 20, Grade = "A+", Branch = "Electronics", Regd_No = 123456789, Section = 'Q' },
                new() {Name = "Vikas Gupta", Age = 19, Grade = "B", Branch = "Computer Science", Regd_No = 123456789, Section = 'R' },
                new() {Name = "Anita Roy", Age = 20, Grade = "AA+", Branch = "Information Technology", Regd_No = 123456789, Section = 'S' },
                new() {Name = "Rajesh Kumar", Age = 21, Grade = "A", Branch = "Mechanical", Regd_No = 123456789, Section = 'T' },
                new() {Name = "Sunita Sharma", Age = 19, Grade = "B+", Branch = "Civil", Regd_No = 123456789, Section = 'U' },
                new() {Name = "Karan Verma", Age = 20, Grade = "A+", Branch = "Electrical", Regd_No = 123456789, Section = 'V' },
                new() {Name = "Pallavi Das", Age = 19, Grade = "AA", Branch = "Electronics", Regd_No = 123456789, Section = 'W' },
                new() {Name = "Nikhil Jain", Age = 21, Grade = "B", Branch = "Computer Science", Regd_No = 123456789, Section = 'X' },
                new() {Name = "Snehal Patil", Age = 20, Grade = "A", Branch = "Information Technology", Regd_No = 123456789, Section = 'Y' },
                new() {Name = "Ravi Shankar", Age = 19, Grade = "B+", Branch = "Mechanical", Regd_No = 123456789, Section = 'Z' },
                new() {Name = "Kavya Iyer", Age = 20, Grade = "AA+", Branch = "Civil", Regd_No = 123456789, Section = 'A' },
                new() {Name = "Aakash Singh", Age = 21, Grade = "A", Branch = "Electrical", Regd_No = 123456789, Section = 'B' },
                new() {Name = "Neha Kapoor", Age = 19, Grade = "B", Branch = "Electronics", Regd_No = 123456789, Section = 'C' },
                new() {Name = "Rohan Desai", Age = 20, Grade = "A+", Branch = "Computer Science", Regd_No = 123456789, Section = 'D' },
                new() {Name = "Priyanka Joshi", Age = 19, Grade = "AA", Branch = "Information Technology", Regd_No = 123456789, Section = 'E' },
                new() {Name = "Suresh Reddy", Age = 21, Grade = "B+", Branch = "Mechanical", Regd_No = 123456789, Section = 'F' },
                new() {Name = "Anjali Sharma", Age = 20, Grade = "A", Branch = "Civil", Regd_No = 123456789, Section = 'G' }
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
        public string? Branch { get; set; }
        public long? Regd_No { get; set; }
        public char? Section { get; set; }
    }
}
