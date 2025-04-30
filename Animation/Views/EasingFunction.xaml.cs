using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace Animation.Views {
    public partial class EasingFunction : ContentPage {
        // Dictionary to store descriptions of each easing function
        private readonly Dictionary<string, string> easingDescriptions = new()
        {
            { "Linear", "Uses a constant velocity and is the default easing function." },
            { "BounceIn", "Bounces the animation at the beginning, creating a bouncy start effect." },
            { "BounceOut", "Bounces the animation at the end, creating a bouncy finish effect." },
            { "CubicIn", "Slowly accelerates the animation, with a gradual start that picks up speed." },
            { "CubicOut", "Quickly decelerates the animation, with a fast start that slows down." },
            { "CubicInOut", "Accelerates at the beginning and decelerates at the end for a smooth transition." },
            { "SinIn", "Smoothly accelerates the animation using a sine wave function." },
            { "SinOut", "Smoothly decelerates the animation using a sine wave function." },
            { "SinInOut", "Smoothly accelerates at the beginning and decelerates at the end using a sine wave." },
            { "SpringIn", "Causes the animation to very quickly accelerate towards the end with a spring-like effect." },
            { "SpringOut", "Causes the animation to quickly decelerate towards the end with a spring-like effect." }
        };

        // Original positions and properties for reset
        private double originalX;
        private double originalY;
        private double originalOpacity;
        private double originalRotation;
        private double originalScale;

        public EasingFunction() {
            InitializeComponent();

            // Set default values
            EasingPicker.SelectedIndex = 0; // Linear
            AnimationPicker.SelectedIndex = 0; // Translation

            // Bind events for live updates
            DurationSlider.ValueChanged += OnDurationChanged!;
            AnimationPicker.SelectedIndexChanged += OnAnimationTypeChanged!;

            // Initialize description
            UpdateDescription();
        }

        protected override void OnAppearing() {
            base.OnAppearing();

            // Save original state for reset
            SaveOriginalState();
        }

        private void SaveOriginalState() {
            originalX = AnimationElement.TranslationX;
            originalY = AnimationElement.TranslationY;
            originalOpacity = AnimationElement.Opacity;
            originalRotation = AnimationElement.Rotation;
            originalScale = AnimationElement.Scale;
        }

        private void ResetElementState() {
            AnimationElement.TranslationX = originalX;
            AnimationElement.TranslationY = originalY;
            AnimationElement.Opacity = originalOpacity;
            AnimationElement.Rotation = originalRotation;
            AnimationElement.Scale = originalScale;
        }

        private void OnEasingSelected(object sender, EventArgs e) {
            UpdateDescription();
            UpdateCurrentSelectionLabels();
        }

        private void OnAnimationTypeChanged(object sender, EventArgs e) {
            UpdateCurrentSelectionLabels();
        }

        private void OnDurationChanged(object sender, ValueChangedEventArgs e) {
            UpdateCurrentSelectionLabels();
        }

        private void UpdateDescription() {
            if (EasingPicker.SelectedItem is string selectedEasing) {
                if (easingDescriptions.TryGetValue(selectedEasing, out string? description)) {
                    EasingDescriptionLabel.Text = $"{selectedEasing}: {description}";
                }
            }
        }

        private void UpdateCurrentSelectionLabels() {
            CurrentEasingLabel.Text = EasingPicker.SelectedItem?.ToString() ?? "Linear";
            CurrentAnimationLabel.Text = AnimationPicker.SelectedItem?.ToString() ?? "Translation";
            CurrentDurationLabel.Text = $"{(int)DurationSlider.Value} ms";
        }

        private async void OnRunAnimationClicked(object sender, EventArgs e) {
            // Disable controls during animation
            RunAnimationButton.IsEnabled = false;

            // Get selected options
            string selectedEasing = EasingPicker.SelectedItem?.ToString() ?? "Linear";
            string selectedAnimation = AnimationPicker.SelectedItem?.ToString() ?? "Translation";
            uint duration = (uint)DurationSlider.Value;

            // Get the easing function
            Easing easing = GetEasingFunction(selectedEasing);

            // Run the selected animation
            await RunSelectedAnimation(selectedAnimation, easing, duration);

            // Re-enable controls
            RunAnimationButton.IsEnabled = true;
        }

        private Easing GetEasingFunction(string easingName) {
            return easingName switch {
                "BounceIn" => Easing.BounceIn,
                "BounceOut" => Easing.BounceOut,
                "CubicIn" => Easing.CubicIn,
                "CubicOut" => Easing.CubicOut,
                "CubicInOut" => Easing.CubicInOut,
                "SinIn" => Easing.SinIn,
                "SinOut" => Easing.SinOut,
                "SinInOut" => Easing.SinInOut,
                "SpringIn" => Easing.SpringIn,
                "SpringOut" => Easing.SpringOut,
                _ => Easing.Linear
            };
        }

        private async Task RunSelectedAnimation(string animationType, Easing easing, uint duration) {
            // Reset to starting position
            ResetElementState();

            switch (animationType) {
                case "Translation":
                    // Get the width of the container to calculate translation distance
                    double containerWidth = AnimationContainer.Width;
                    double distance = containerWidth - AnimationElement.Width - 20; // Subtract element width and padding

                    // If container width is not yet determined, use a default value
                    if (containerWidth <= 0)
                        distance = 300;

                    await AnimationElement.TranslateTo(distance, 0, duration, easing);
                    break;

                case "Rotation":
                    await AnimationElement.RotateTo(360, duration, easing);
                    break;

                case "Scale":
                    await AnimationElement.ScaleTo(2, duration / 2, easing);
                    await AnimationElement.ScaleTo(1, duration / 2, easing);
                    break;

                case "Fade":
                    await AnimationElement.FadeTo(0, duration / 2, easing);
                    await AnimationElement.FadeTo(1, duration / 2, easing);
                    break;
            }
        }

        private void OnResetClicked(object sender, EventArgs e) {
            ResetElementState();
        }
    }
}


