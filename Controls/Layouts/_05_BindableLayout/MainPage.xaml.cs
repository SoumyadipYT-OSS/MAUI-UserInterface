using _05_BindableLayout.ViewModel;


namespace _05_BindableLayout 
{
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            BindingContext = new ViewModel.MainPageViewModel();
        }
    }
}