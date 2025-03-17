using _21_ListView.ViewModel;
using Microsoft.Maui.Controls;

namespace _21_ListView
{
    public partial class App : Application
    {
        // Singleton instance of MainViewModel
        public static MainViewModel? MVM { get; private set; }

        public App()
        {
            InitializeComponent();
            MVM = new MainViewModel();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}