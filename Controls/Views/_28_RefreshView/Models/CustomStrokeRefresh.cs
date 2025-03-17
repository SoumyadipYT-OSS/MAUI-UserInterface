using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;
using System.Threading.Tasks;

namespace _28_RefreshView.Models
{
    public class CustomStrokeRefresh : GraphicsView, IDrawable
    {
        // The current starting angle of the arc.
        private float _angle = 0;
        private bool _isAnimating = false;

        public CustomStrokeRefresh() {
            Drawable = (IDrawable)this;
        }

        // This method draws a background circle and an arc (stroke) that rotates.
        public void Draw(ICanvas canvas, RectF dirtyRect) {
            canvas.SaveState();

            // Calculate a radius based on the available space.
            float radius = Math.Min(dirtyRect.Width, dirtyRect.Height) / 2 - 5;
            PointF center = new PointF(dirtyRect.Center.X, dirtyRect.Center.Y);

            // Draw a light-gray circle as a background.
            canvas.StrokeSize = 4;
            canvas.StrokeColor = Colors.LightGray;
            canvas.DrawCircle(center.X, center.Y, radius);

            // Draw a blue arc (the “stroke design”) that covers 90°.
            canvas.StrokeColor = Colors.Blue;
            float sweepAngle = 90;
            canvas.DrawArc(
                new RectF(center.X - radius, center.Y - radius, radius * 2, radius * 2),
                _angle,
                sweepAngle,
                false,
                false);

            canvas.RestoreState();
        }

        // Animate the stroke by incrementing the starting angle.
        public async void Animate() {
            if (_isAnimating)
                return;

            _isAnimating = true;
            while (_isAnimating) {
                _angle += 5;
                if (_angle >= 360)
                    _angle = 0;
                Invalidate(); // Redraw the control.
                await Task.Delay(30);
            }
        }

        // Stop the animation loop.
        public void StopAnimation() {
            _isAnimating = false;
        }
    }
}
