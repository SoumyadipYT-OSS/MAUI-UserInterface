using Microsoft.Maui.Controls;
using _37_TextCell.Examples;

namespace _37_TextCell
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(BasicTextCell), typeof(BasicTextCell));
            Routing.RegisterRoute(nameof(AdvancedTextCell), typeof(AdvancedTextCell));
        }
    }
}