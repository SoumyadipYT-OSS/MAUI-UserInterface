using _24_Picker.ViewModel;


namespace _24_Picker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MonkeyViewModel(); 
        }
    }
}
