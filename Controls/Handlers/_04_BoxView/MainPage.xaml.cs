using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace _04_BoxView {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            AnimateBoxView();
            AnimateColorBoxView();
        }

        private async void AnimateBoxView() {
            while (true) {
                await animatedBoxView.RotateTo(360, 2000);
                animatedBoxView.Rotation = 0;
            }
        }

        private async void AnimateColorBoxView() {
            while (true) {
                await colorAnimatedBoxView.ColorTo(Colors.Purple, Colors.Green, c => colorAnimatedBoxView.Color = c, 2000);
                await colorAnimatedBoxView.ColorTo(Colors.Green, Colors.Purple, c => colorAnimatedBoxView.Color = c, 2000);
            }
        }
    }

    public static class AnimationExtensions {
        public static Task<bool> ColorTo(this VisualElement element, Color fromColor, Color toColor, Action<Color> callback, uint length = 250, Easing? easing = null) {
            Func<double, Color> transform = t =>
                Color.FromRgba(fromColor.Red + t * (toColor.Red - fromColor.Red),
                               fromColor.Green + t * (toColor.Green - fromColor.Green),
                               fromColor.Blue + t * (toColor.Blue - fromColor.Blue),
                               fromColor.Alpha + t * (toColor.Alpha - fromColor.Alpha));
#pragma warning disable CS8604
            return ColorAnimation(element, "ColorTo", transform, callback, length, easing);
#pragma warning restore CS8604
        }

        public static Task<bool> ColorAnimation(VisualElement element, string name, Func<double, Color> transform, Action<Color> callback, uint length, Easing easing) {
            easing = easing ?? Easing.Linear;
            var taskCompletionSource = new TaskCompletionSource<bool>();

            element.Animate(name, new Animation(t => callback(transform(t))), 16, length, easing, (v, c) => taskCompletionSource.SetResult(c));

            return taskCompletionSource.Task;
        }
    }
}