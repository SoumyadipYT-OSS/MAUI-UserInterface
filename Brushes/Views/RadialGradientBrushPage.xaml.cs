using Microsoft.Maui.Controls.Shapes;

namespace Brushes.Views;

public partial class RadialGradientBrushPage : ContentPage {
    // Colors for the interactive gradient
    private readonly Microsoft.Maui.Graphics.Color[] _gradientColors =
    [
        Colors.MediumPurple,
        Colors.DeepPink,
        Colors.OrangeRed
    ];

    public RadialGradientBrushPage() {
        InitializeComponent();

        // Set up the initial gradient
        UpdateRadialGradient();

        // Add event handlers for the sliders
        centerXSlider.ValueChanged += (s, e) => UpdateRadialGradient();
        centerYSlider.ValueChanged += (s, e) => UpdateRadialGradient();
        radiusSlider.ValueChanged += (s, e) => UpdateRadialGradient();
    }

    private void UpdateRadialGradient() {
        double centerX = centerXSlider.Value;
        double centerY = centerYSlider.Value;
        double radius = radiusSlider.Value;

        // Update the info display
        gradientInfo.Text = $"Center=({centerX:F2}, {centerY:F2}), Radius={radius:F2}";

        // Create a new RadialGradientBrush
        var brush = new RadialGradientBrush {
            Center = new Point(centerX, centerY),
            Radius = radius
        };

        // Add gradient stops
        brush.GradientStops.Add(new GradientStop(_gradientColors[0], 0.0f));
        brush.GradientStops.Add(new GradientStop(_gradientColors[1], 0.5f));
        brush.GradientStops.Add(new GradientStop(_gradientColors[2], 1.0f));

        // Apply the brush to the rectangle
        interactiveRadialGradient.Fill = brush;
    }
}