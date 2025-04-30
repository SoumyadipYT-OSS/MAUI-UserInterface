using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Dispatching;
using System.Collections.Generic;

namespace Animation.Views {
    public partial class CustomAnimation : ContentPage {
        // Animation fields
        private bool isPulseAnimationRunning = false;
        private IDispatcherTimer pulseTimer;
        private Random random = new Random();
        private bool isCardFlipped = false;
        private bool isBurstInProgress = false;
        private List<Shape> particles = new List<Shape>();

        public CustomAnimation() {
            InitializeComponent();

            // Initialize the pulse timer
            pulseTimer = Dispatcher.CreateTimer();
            pulseTimer.Interval = TimeSpan.FromMilliseconds(1500);
            pulseTimer.Tick += (s, e) => AnimatePulse();
        }

        #region Pulse Animation

        private void OnPulseAnimationClicked(object sender, EventArgs e) {
            if (!isPulseAnimationRunning) {
                StartPulseAnimation();
            } else {
                StopPulseAnimation();
            }
        }

        private void StartPulseAnimation() {
            isPulseAnimationRunning = true;
            AnimatePulse();
            pulseTimer.Start();
        }

        private void StopPulseAnimation() {
            isPulseAnimationRunning = false;
            pulseTimer.Stop();

            // Reset circles
            PulseCircle1.Scale = 0.6;
            PulseCircle1.Opacity = 1;
            PulseCircle2.Scale = 0.6;
            PulseCircle2.Opacity = 1;
            PulseCircle3.Scale = 0.6;
            PulseCircle3.Opacity = 1;
        }

        private void AnimatePulse() {
            // Animate each circle with a delay
            AnimatePulseCircle(PulseCircle1, 0);
            AnimatePulseCircle(PulseCircle2, 200);
            AnimatePulseCircle(PulseCircle3, 400);
        }

        private async void AnimatePulseCircle(VisualElement circle, int delay) {
            await Task.Delay(delay);

            // Create pulse effect by scaling up and fading out
            await Task.WhenAll(
                circle.ScaleTo(1.2, 500, Easing.CubicOut),
                circle.FadeTo(0.2, 500, Easing.CubicOut)
            );

            // Reset for next pulse
            circle.Scale = 0.6;
            circle.Opacity = 1;
        }

        #endregion

        #region Card Flip Animation

        private void OnCardTapped(object sender, TappedEventArgs e) {
            if (!isCardFlipped) {
                FlipCardToBack();
            } else {
                FlipCardToFront();
            }
        }

        private async void FlipCardToBack() {
            // First half of the flip animation (front card)
            await CardFront.ScaleTo(0.8, 200, Easing.CubicIn);
            await CardFront.FadeTo(0, 100);

            // Second half of the flip animation (back card)
            await CardBack.FadeTo(1, 100);
            await CardBack.ScaleTo(1.0, 200, Easing.CubicOut);

            isCardFlipped = true;
        }

        private async void FlipCardToFront() {
            // First half of the flip animation (back card)
            await CardBack.ScaleTo(0.8, 200, Easing.CubicIn);
            await CardBack.FadeTo(0, 100);

            // Second half of the flip animation (front card)
            await CardFront.FadeTo(1, 100);
            await CardFront.ScaleTo(1.0, 200, Easing.CubicOut);

            isCardFlipped = false;
        }

        #endregion

        #region Particle Burst Animation

        private async void OnBurstAnimationClicked(object sender, EventArgs e) {
            if (isBurstInProgress)
                return;

            isBurstInProgress = true;

            try {
                // Clear previous particles
                foreach (var particle in particles) {
                    ParticleContainer.Children.Remove(particle);
                }
                particles.Clear();

                // Calculate center point
                double centerX = ParticleContainer.Width / 2;
                double centerY = ParticleContainer.Height / 2;

                // Create particles
                const int numberOfParticles = 20;
                for (int i = 0; i < numberOfParticles; i++) {
                    // Create a random shape (circle or rectangle)
                    Shape particle = random.Next(2) == 0
                        ? CreateParticleCircle()
                        : CreateParticleRectangle();

                    // Add to container
                    ParticleContainer.Children.Add(particle);
                    particles.Add(particle);

                    // Position at center
                    AbsoluteLayout.SetLayoutBounds(particle, new Rect(centerX, centerY, 10, 10));

                    // Animate the particle
                    AnimateParticle(particle, centerX, centerY);
                }

                // Wait for animations to complete
                await Task.Delay(2000);
            } finally {
                isBurstInProgress = false;
            }
        }

        private Ellipse CreateParticleCircle() {
            return new Ellipse {
                Fill = new SolidColorBrush(GetRandomColor()),
                WidthRequest = random.Next(5, 15),
                HeightRequest = random.Next(5, 15),
                Opacity = 1
            };
        }

        private Rectangle CreateParticleRectangle() {
            return new Rectangle {
                Fill = new SolidColorBrush(GetRandomColor()),
                WidthRequest = random.Next(5, 15),
                HeightRequest = random.Next(5, 15),
                Opacity = 1,
                RotationX = random.Next(0, 360)
            };
        }

        private Color GetRandomColor() {
            // Vibrant celebration colors
            Color[] colors = new[]
            {
                Colors.Red,
                Colors.DeepPink,
                Colors.Orange,
                Colors.Yellow,
                Colors.LimeGreen,
                Colors.Cyan,
                Colors.Blue,
                Colors.Purple
            };

            return colors[random.Next(colors.Length)];
        }

        private async void AnimateParticle(VisualElement particle, double centerX, double centerY) {
            // Calculate a random destination point
            double angle = random.NextDouble() * Math.PI * 2; // Random angle
            double distance = random.Next(50, 150); // Random distance
            double destX = centerX + Math.Cos(angle) * distance;
            double destY = centerY + Math.Sin(angle) * distance;

            // Random initial rotation
            double initialRotation = random.Next(0, 360);
            particle.Rotation = initialRotation;

            // Animate the particle
            uint duration = (uint)random.Next(500, 1500);
            uint fadeDelay = (uint)random.Next(200, 800);

            // Start multiple animations
            var translateTask = particle.TranslateTo(destX - centerX, destY - centerY, duration, Easing.CubicOut);
            var scaleTask = particle.ScaleTo(random.NextDouble() * 2 + 0.5, duration, Easing.CubicOut);
            var rotateTask = particle.RotateTo(initialRotation + random.Next(-360, 360), duration, Easing.CubicOut);

            // Wait a bit before starting to fade out
            await Task.Delay((int)fadeDelay);
            await particle.FadeTo(0, duration - fadeDelay, Easing.CubicIn);
        }

        #endregion
    }
}

