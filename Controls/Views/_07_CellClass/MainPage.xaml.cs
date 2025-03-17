namespace _07_CellClass 
{
    public partial class MainPage : ContentPage {
        public bool NotificationsEnabled { get; set; }
        public double SliderValue { get; set; }

        public MainPage() {
            InitializeComponent();
            NotificationsEnabled = true;
            SliderValue = 50;
            BindingContext = this;
        }
    }
}