using Microsoft.Maui.Controls;
using _36_TableView.TableClass;


namespace _36_TableView
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(BasicTable), typeof(BasicTable));
            Routing.RegisterRoute(nameof(AdvancedTable), typeof(AdvancedTable));
        }
    }
}