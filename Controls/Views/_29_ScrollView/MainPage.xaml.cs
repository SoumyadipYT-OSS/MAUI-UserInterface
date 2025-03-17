using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace _29_ScrollView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // The Scrolled event provides real-time coordinates for scroll position changes.
        private void OnScrolled(object sender, ScrolledEventArgs e) {
            Debug.WriteLine($"Scrolled to (X: {e.ScrollX}, Y: {e.ScrollY})");
        }
    }

}
