using _35_SwitchCell.CustomSwitchCell;
using Microsoft.Maui.Controls;

namespace _35_SwitchCell
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SwitchCellDemoPage), typeof(SwitchCellDemoPage));
        }
    }
}