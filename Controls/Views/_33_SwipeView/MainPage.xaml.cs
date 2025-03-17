using Microsoft.Maui.Controls;

namespace _33_SwipeView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        void OnDelete(object sender, EventArgs e) {
            DisplayAlert("Action", "Delete action triggered", "OK");
        }

        void OnArchive(object sender, EventArgs e) {
            DisplayAlert("Action", "Archive action triggered", "OK");
        }
    }

}