using Microsoft.Maui.Controls;

namespace _40_TwoPaneView {
    public partial class MainPage : ContentPage {
        // Threshold for switching between dual-pane and single-pane modes.
        private const double DualPaneMinWidth = 700;

        public MainPage() {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height) {
            base.OnSizeAllocated(width, height);

            if (width >= DualPaneMinWidth) {
                // Dual-pane mode: both panes take equal space.
                Col1.Width = new GridLength(1, GridUnitType.Star);
                Col2.Width = new GridLength(1, GridUnitType.Star);
            } else {
                // Single-pane mode: collapse the second pane.
                Col1.Width = new GridLength(1, GridUnitType.Star);
                Col2.Width = new GridLength(0);
            }
        }
    }
}