using _01_Align_and_Position_Controls.Examples;

namespace _01_Align_and_Position_Controls
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Microsoft.Maui.Controls.Routing.RegisterRoute(nameof(BasicDemo), typeof(BasicDemo));
            Microsoft.Maui.Controls.Routing.RegisterRoute(nameof(AdvancedDemo), typeof(AdvancedDemo));

        }
    }
}