using Microsoft.Maui.Controls;
using _21_ListView.ViewModel;


namespace _21_ListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = App.MVM;
        }
    }

}

