using Microsoft.Maui.Controls;
using System.Timers;


namespace _18_IndicatorView {
    public partial class MainPage : ContentPage {
        private readonly System.Timers.Timer _carouselTimer;
        private int _currentIndex = 0;

        public MainPage() {
            InitializeComponent();
            BindingContext = new ViewModel.MainViewModel();

            // Set up the timer
            _carouselTimer = new System.Timers.Timer(3000);
            _carouselTimer.Elapsed += OnTimerElapsed;
            _carouselTimer.Start();
        }



        private void OnTimerElapsed(object? sender, ElapsedEventArgs e) {
            // Move to the next item
            _currentIndex++;
            if (_currentIndex >= ((ViewModel.MainViewModel)BindingContext).MobileBrands.Count) {
                _currentIndex = 0; // Reset to the first item if we reach the end
            }

            // Update the carousel position on the main thread
            MainThread.BeginInvokeOnMainThread(() => {
                carouselView.Position = _currentIndex;
            });
        }

        protected override void OnDisappearing() {
            base.OnDisappearing();
            _carouselTimer.Stop();
        }

        protected override void OnAppearing() {
            base.OnAppearing();
            _carouselTimer.Start();
        }

    }
}

