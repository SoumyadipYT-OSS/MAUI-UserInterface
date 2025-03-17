using Microsoft.Maui.Controls;

namespace _40_TwoPaneView {
    public partial class AdvancedTwoPaneViewPage : ContentPage {
        // Define threshold width for transitioning between dual-pane and single-pane modes.
        private const double DualPaneMinWidth = 800;

        public AdvancedTwoPaneViewPage() {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height) {
            base.OnSizeAllocated(width, height);

            // Toggle visual states based on the width of the page.
            if (width >= DualPaneMinWidth)
                VisualStateManager.GoToState(MainGrid, "DualPane");
            else
                VisualStateManager.GoToState(MainGrid, "SinglePane");
        }
    }
}