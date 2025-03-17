using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
#if ANDROID
using Android.Media;
#endif


namespace _17_ImageButton
{
    public partial class MainPage : ContentPage
    {
#if ANDROID
        private MediaPlayer? _mediaPlayer;
#endif

        public MainPage()
        {
            InitializeComponent();
            AddAnimations();
#if ANDROID
            LoadAudio();
#endif
        }

        private void AddAnimations() {
            var button = AnimatedButton;

            var scaleDownAnimation = new Animation(v => button.Scale = v, 1, 0.8, Easing.CubicInOut);
            var scaleUpAnimation = new Animation(v => button.Scale = v, 0.8, 1, Easing.CubicIn);

            button.Pressed += (sender, args) => scaleDownAnimation.Commit(button, "ScaleDownAnimation", length: 200);
            button.Released += (sender, args) => scaleUpAnimation.Commit(button, "ScaleUpAnimation", length: 200);
        }

#if ANDROID
        private void LoadAudio() {
            var aM = Android.App.Application.Context.Assets;
            _mediaPlayer = new MediaPlayer();

            var fD = aM!.OpenFd("button_freesound.mp3");
            _mediaPlayer.SetDataSource(fD.FileDescriptor, fD.StartOffset, fD.Length);
            _mediaPlayer.Prepare();
        }


        private void OnImageButtonClicked(object? sender, EventArgs e) {
            _mediaPlayer!.Start();
            DisplayAlert("ImageButton Clicked", "You clicked the animated image button!", "OK");
        }

        protected override void OnDisappearing() {
            base.OnDisappearing();
            _mediaPlayer!.Release();
        }
#endif
    }

}
