using Microsoft.Maui.Controls;
using _38_TimePicker.Examples;


namespace _38_TimePicker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Routers for adding C# page [Concurrent running / Multi-Threading handle]
            Routing.RegisterRoute(nameof(BasicTimePickerDemo), typeof(BasicTimePickerDemo));
            Routing.RegisterRoute(nameof(AdvancedTimePickerDemo), typeof(AdvancedTimePickerDemo));
        }
    }
}