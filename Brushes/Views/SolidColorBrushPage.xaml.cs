using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Brushes.Views;

public partial class SolidColorBrushPage : ContentPage, INotifyPropertyChanged {
    private Microsoft.Maui.Graphics.Color _colorValue = Microsoft.Maui.Graphics.Colors.Black; // Initialize with a default value

    // Theme colors
    private readonly Microsoft.Maui.Graphics.Color _lightBackgroundColor = Microsoft.Maui.Graphics.Colors.White;
    private readonly Microsoft.Maui.Graphics.Color _lightTextColor = Microsoft.Maui.Graphics.Colors.Black;
    private readonly Microsoft.Maui.Graphics.Color _lightBorderColor = Microsoft.Maui.Graphics.Color.FromRgb(230, 230, 230);
    private readonly Microsoft.Maui.Graphics.Color _lightButtonColor = Microsoft.Maui.Graphics.Color.FromRgb(0, 122, 255);

    private readonly Microsoft.Maui.Graphics.Color _darkBackgroundColor = Microsoft.Maui.Graphics.Color.FromRgb(30, 30, 30);
    private readonly Microsoft.Maui.Graphics.Color _darkTextColor = Microsoft.Maui.Graphics.Colors.White;
    private readonly Microsoft.Maui.Graphics.Color _darkBorderColor = Microsoft.Maui.Graphics.Color.FromRgb(70, 70, 70);
    private readonly Microsoft.Maui.Graphics.Color _darkButtonColor = Microsoft.Maui.Graphics.Color.FromRgb(0, 95, 200);


    public Microsoft.Maui.Graphics.Color ColorValue {
        get => _colorValue;
        set {
            if (_colorValue != value) {
                _colorValue = value;
                OnPropertyChanged();
            }
        }
    }

    public SolidColorBrushPage() {
        InitializeComponent();
        BindingContext = this;

        // Set initial color
        UpdateColor();

        // Add event handlers for sliders
        redSlider.ValueChanged += (s, e) => UpdateColor();
        greenSlider.ValueChanged += (s, e) => UpdateColor();
        blueSlider.ValueChanged += (s, e) => UpdateColor();
    }


    private void UpdateColor() {
        ColorValue = Microsoft.Maui.Graphics.Color.FromRgb(
            (int)redSlider.Value,
            (int)greenSlider.Value,
            (int)blueSlider.Value);
    }

    private void OnThemeSwitchToggled(object sender, ToggledEventArgs e) {
        ApplyTheme(e.Value);
    }

    public new event PropertyChangedEventHandler? PropertyChanged;

    protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        base.OnPropertyChanged(propertyName);
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void ApplyTheme(bool isDarkMode) {
        // Update theme label
        themeLabel.Text = isDarkMode ? "Dark Mode" : "Light Mode";
        themeTitleLabel.Text = isDarkMode ? "Dark Theme Content" : "Light Theme Content";

        // Update container background and border
        themeContainer.Background = new SolidColorBrush(isDarkMode ? _darkBackgroundColor : _lightBackgroundColor);
        themeContainer.Stroke = new SolidColorBrush(isDarkMode ? _darkBorderColor : _lightBorderColor);

        // Update text colors
        themeTitleLabel.TextColor = isDarkMode ? _darkTextColor : _lightTextColor;

        // Update button colors
        themeButton.BackgroundColor = isDarkMode ? _darkButtonColor : _lightButtonColor;
        themeButton.TextColor = Microsoft.Maui.Graphics.Colors.White;

        // Update checkbox colors
        themeCheckBox.Color = isDarkMode ? _darkButtonColor : _lightButtonColor;
    }
}