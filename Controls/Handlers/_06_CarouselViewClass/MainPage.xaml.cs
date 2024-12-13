using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Timers;

namespace _06_CarouselViewClass {
    public partial class MainPage : ContentPage {
        public ObservableCollection<string> Images { get; set; }
        
        // making readonly can improve code safety and clarity
        private readonly System.Timers.Timer _timer;

        public MainPage() {
            InitializeComponent();
            Images = [
                "Resources/Images/avocado.svg",
                "Resources/Images/grape.svg",
                "Resources/Images/kiwi.svg",
                "Resources/Images/lemon.svg",
                "Resources/Images/waterlemon.svg"
            ];
            BindingContext = this;

            // Initialize and start the timer for automatic scrolling
            _timer = new System.Timers.Timer(2000); // Change slide every 2 seconds
            _timer.Elapsed += OnTimerElapsed;
            _timer.Start();
        }


        private void OnTimerElapsed(object? sender, ElapsedEventArgs? e) {
            Dispatcher.Dispatch(() => {
                // Update the CarouselView if not dragging
                if (!modernCarouselView.IsDragging) {
                    UpdateCarouselView(modernCarouselView);
                }
            });
        }

        private void UpdateCarouselView(CarouselView carouselView) {
            if (carouselView.Position == Images.Count - 1) {
                carouselView.Position = 0;
            } else {
                carouselView.Position += 1;
            }
        }

        private void OnPositionChanged(object sender, PositionChangedEventArgs e) {
            // Update the IndicatorView when the position changes
            modernIndicatorView.SelectedIndicatorColor = Colors.Black;
        }

        protected override void OnDisappearing() {
            base.OnDisappearing();
            _timer.Stop();
            _timer.Dispose();
        }
    }
}