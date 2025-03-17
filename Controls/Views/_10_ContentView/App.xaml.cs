using Microsoft.Maui.Controls;

namespace _10_ContentView {
    public partial class App : Application {
        protected override Window CreateWindow(IActivationState? activationState) {
            var window = new Window(new NavigationPage(new MainPage()));
            return window;
        }
    }
}
