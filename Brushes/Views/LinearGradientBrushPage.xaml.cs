using Microsoft.Maui.Controls.Shapes;
using System;

namespace Brushes.Views;

public partial class LinearGradientBrushPage : ContentPage
{
	// Colors for the interactive gradient
	private readonly Microsoft.Maui.Graphics.Color[] _gradientColors = [
		Colors.MediumPurple,
		Colors.DeepSkyBlue,
		Colors.Aquamarine
	];


	public LinearGradientBrushPage()
	{
		InitializeComponent();

		// Set up the initial gradient
		UpdateGradient(0);

		// Add event handler for the slider
		angleSlider.ValueChanged += (s, e) => {
			UpdateGradient(e.NewValue);
		};

	}

	private void UpdateGradient(double angle) {
		angleDisplay.Text = $"Angle: {angle:F0}°";

		// Convert angle to radians
		double radians = Math.PI * angle / 180.0;

		// Calculate start and end points based on angle
		double x1 = 0.5 - 0.5 * Math.Cos(radians);
		double y1 = 0.5 - 0.5 * Math.Sin(radians);
        double x2 = 0.5 + 0.5 * Math.Cos(radians);
        double y2 = 0.5 + 0.5 * Math.Sin(radians);

		// Create a new LinearGradientBrush
		var brush = new LinearGradientBrush {
			StartPoint = new Point(x1, y1),
			EndPoint = new Point(x2, y2),
		};

		// Add gradient stops
		brush.GradientStops.Add(new GradientStop(_gradientColors[0], 0.0f));
		brush.GradientStops.Add(new GradientStop(_gradientColors[1], 0.5f));
		brush.GradientStops.Add(new GradientStop(_gradientColors[2], 1.0f));

		// Apply the brush to the rectangle
		interactiveGradient.Fill = brush;
    }
}