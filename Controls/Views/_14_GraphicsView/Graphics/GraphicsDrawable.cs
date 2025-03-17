
using Microsoft.Maui.Graphics;

namespace _14_GraphicsView.Graphics {
    public class GraphicsDrawable : Microsoft.Maui.Graphics.IDrawable {
        public string? GraphicType { get; set; }

        public void Draw(ICanvas canvas, RectF dirtyRect) {
            switch (GraphicType) {
                case "Circle":
                    DrawCircle(canvas, dirtyRect); break;
                case "Rectangle":
                    DrawRectangle(canvas, dirtyRect); break;
                case "Line":
                    DrawLine(canvas, dirtyRect); break;
                case "Text":
                    DrawText(canvas, dirtyRect); break;
                case "Ellipse":
                    DrawEllipse(canvas, dirtyRect); break;
                case "CustomDraw":
                    CustomDraw(canvas, dirtyRect); break;
                case "CustomPolygon":
                    CustomPolygon(canvas, dirtyRect); break;
                case "GradientBackgroundShape":
                    GradientBackgroundShape(canvas, dirtyRect); break;
                case "TextWithShadow":
                    TextWithShadow(canvas, dirtyRect); break;
            }
        }

        private static void DrawCircle(ICanvas canvas, RectF dirtyRect) {
            canvas.FillColor = Colors.Blue;
            canvas.FillCircle(dirtyRect.Center.X, dirtyRect.Center.Y, 50);
        }
        private static void DrawRectangle(ICanvas canvas, RectF dirtyRect) {
            canvas.FillColor = Colors.Red;
            canvas.FillRectangle(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height);
        }
        private static void DrawLine(ICanvas canvas, RectF dirtyRect) {
            canvas.StrokeColor = Colors.Green;
            canvas.StrokeSize = 5;
            canvas.DrawLine(0, 0, dirtyRect.Width, dirtyRect.Height);
        }
        private static void DrawText(ICanvas canvas, RectF dirtyRect) {
            canvas.FontColor = Colors.Magenta;
            canvas.FontSize = 24;
            canvas.DrawString("Hello, GraphicsView!", dirtyRect.Center.X, dirtyRect.Center.Y, HorizontalAlignment.Center);
        }
        private static void DrawEllipse(ICanvas canvas, RectF dirtyRect) {
            canvas.FillColor = Colors.Yellow;
            canvas.FillEllipse(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height);
        }
        private static void CustomDraw(ICanvas canvas, RectF dirtyRect) {
            // Draw gradient background
            var gradient = new LinearGradientBrush(
                [
                    new GradientStop(Colors.LightCoral, 0),
                    new GradientStop(Colors.LemonChiffon, 1),
                ],
                new Point(0, 0),
                new Point(1, 1)
            );

            canvas.SetFillPaint(gradient, dirtyRect);
            canvas.FillRectangle(dirtyRect);

            // Drawing a custom shape
            canvas.FillColor = Colors.Coral;
            canvas.FillRoundedRectangle(50, 50, 200, 100, 20);
        }
        private static void CustomPolygon(ICanvas canvas, RectF dirtyRect) {
            var path = new PathF();
            path.MoveTo(dirtyRect.X, dirtyRect.Y);
            path.MoveTo(50, 50);
            path.LineTo(200, 50);
            path.LineTo(150, 150);
            path.LineTo(100, 150);
            path.Close();

            canvas.FillColor= Colors.Chartreuse;
            canvas.FillPath(path);

            canvas.StrokeColor = Colors.BlanchedAlmond;
            canvas.StrokeSize = 2;
            canvas.DrawPath(path);
        }
        private static void GradientBackgroundShape(ICanvas canvas, RectF dirtyRect) {
            // Draw gradient background
            var gradient = new LinearGradientBrush(
                [
                    new GradientStop(Colors.LightBlue, 0),
                    new GradientStop(Colors.DeepSkyBlue, 1),
                ],
                new Point(0, 0),
                new Point(1, 1)
            );

            canvas.SetFillPaint(gradient, dirtyRect);
            canvas.FillRectangle(dirtyRect);

            // Draw custom shape
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(50, 50, 200, 100, 20);
        }
        private static void TextWithShadow(ICanvas canvas, RectF dirtyRect) {
            var text = "Modern Design";

            // Draw shadow
            canvas.FontColor = Colors.Gray;
            canvas.FontSize = 25;
            canvas.DrawString(text, 2, 2, dirtyRect.Width, dirtyRect.Height, HorizontalAlignment.Center, VerticalAlignment.Center, TextFlow.ClipBounds, 1);

            // Draw text
            canvas.FontColor = Colors.Black;
            canvas.DrawString(text, 0, 0, dirtyRect.Width, dirtyRect.Height, HorizontalAlignment.Center, VerticalAlignment.Center, TextFlow.ClipBounds, 1);
        }


    }
}