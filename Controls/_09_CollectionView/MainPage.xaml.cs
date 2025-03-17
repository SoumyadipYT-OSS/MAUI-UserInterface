using _09_CollectionView.ViewModels;
using Microsoft.Maui.Controls;


namespace _09_CollectionView {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            BindingContext = new BooksViewModel();
        }
    }
}