using _01_ActivityIndicator.ViewModel;

namespace _01_ActivityIndicator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new IsBusyViewModel();
        }
    }
}
