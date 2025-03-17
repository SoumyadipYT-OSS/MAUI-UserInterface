using System.Collections.ObjectModel;
using _09_CollectionView.Models;

namespace _09_CollectionView.ViewModels {
    public class BooksViewModel {
        public ObservableCollection<Book> Books { get; set; }

        public BooksViewModel() {
            Books =
            [
                new()
                {
                    Title = "The Guide",
                    Author = "R.K. Narayan",
                    Genre = "Fiction",
                    CoverImageUrl = "https://th.bing.com/th/id/OIP.jvXaXavEAjrjaJ0xQYBeJQAAAA?rs=1&pid=ImgDetMain",
                    Description = "A novel exploring the transformation of Raju from a tour guide to a spiritual guide.",
                    Price = 249.89m
                },
                new()
                {
                    Title = "Midnight's Children",
                    Author = "Salman Rushdie",
                    Genre = "Historical Fiction",
                    CoverImageUrl = "https://stat1.bollywoodhungama.in/wp-content/uploads/2016/03/Midnights-Children.jpg",
                    Description = "A story following the life of Saleem Sinai, born at the exact moment of India's independence.",
                    Price = 180.89m
                },
                new()
                {
                    Title = "God of Small Things",
                    Author = "Arundhati Roy",
                    Genre = "Fiction",
                    CoverImageUrl = "https://n1.sdlcdn.com/imgs/i/q/9/Arundhati-Roy-S-The-God-SDL373486293-1-7fda6.jpg",
                    Description = "A tale exploring the childhood experiences of fraternal twins in Kerala.",
                    Price = 149.99m
                },
                new()
                {
                    Title = "The White Tiger",
                    Author = "Aravind Adiga",
                    Genre = "Fiction",
                    CoverImageUrl = "https://rukminim2.flixcart.com/image/850/1000/book/7/5/0/aravind-adiga-s-the-white-tiger-original-imaepy4hzyrnyvkb.jpeg?q=90&crop=false",
                    Description = "A novel about the rise of Balram Halwai from a poor villager to a successful entrepreneur in modern India.",
                    Price = 199.29m
                }
            ];
        }
    }
}