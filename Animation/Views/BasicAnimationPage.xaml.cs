using Microsoft.Maui.Controls;
using System;

namespace Animation.Views {
    public partial class BasicAnimationPage : ContentPage {
        bool isFaded = true;
        bool isScaled = false;

        public BasicAnimationPage() {
            InitializeComponent();
        }

        private async void OnFadeClicked(object sender, EventArgs e) {
            // Toggle fade in/out
            double targetOpacity = isFaded ? 1.0 : 0.3;
            await FadeBox.FadeTo(targetOpacity, 500, Easing.CubicInOut);
            isFaded = !isFaded;
        }

        private async void OnRotateClicked(object sender, EventArgs e) {
            // Rotate 360 degrees
            await RotateImage.RotateTo(360, 1000, Easing.SpringOut);
            RotateImage.Rotation = 0; // Reset rotation
        }

        private async void OnScaleClicked(object sender, EventArgs e) {
            // Toggle scale up/down
            double targetScale = isScaled ? 1.0 : 1.5;
            await ScaleBox.ScaleTo(targetScale, 500, Easing.BounceOut);
            isScaled = !isScaled;
        }

        private async void OnTranslateClicked(object sender, EventArgs e) {
            // Translate from left to right and back
            await TranslateBox.TranslateTo(200, 0, 750, Easing.CubicOut);
            await TranslateBox.TranslateTo(0, 0, 750, Easing.CubicIn);
        }

        private async void OnCombinedClicked(object sender, EventArgs e) {
            // Combined animation: fade, rotate, scale at the same time
            var fadeTask = CombinedImage.FadeTo(0.5, 500);
            var rotateTask = CombinedImage.RotateTo(180, 500);
            var scaleTask = CombinedImage.ScaleTo(1.5, 500);

            await Task.WhenAll(fadeTask, rotateTask, scaleTask);
            await Task.Delay(500);

            // Animate back to original state
            var fadeBackTask = CombinedImage.FadeTo(1, 500);
            var rotateBackTask = CombinedImage.RotateTo(0, 500);
            var scaleBackTask = CombinedImage.ScaleTo(1, 500);

            await Task.WhenAll(fadeBackTask, rotateBackTask, scaleBackTask);
        }
    }
}