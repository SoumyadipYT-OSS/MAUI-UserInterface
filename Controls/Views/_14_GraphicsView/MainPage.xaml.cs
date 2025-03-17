using _14_GraphicsView.Graphics;

namespace _14_GraphicsView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Create instances of GraphicsDrawable with different graphic types
            var circleDrawable = new GraphicsDrawable { GraphicType = "Circle" };
            var rectangleDrawable = new GraphicsDrawable { GraphicType = "Rectangle" };
            var lineDrawable = new GraphicsDrawable { GraphicType = "Line" };
            var textDrawable = new GraphicsDrawable { GraphicType = "Text" };
            var ellipseDrawable = new GraphicsDrawable { GraphicType = "Ellipse" };
            var customDrawable = new GraphicsDrawable { GraphicType = "CustomDraw" };
            var customPolygon = new GraphicsDrawable { GraphicType = "CustomPolygon" };
            var gradientBackgroundShape = new GraphicsDrawable { GraphicType = "GradientBackgroundShape" };
            var textWithShadow = new GraphicsDrawable { GraphicType = "TextWithShadow" };

            // Assign drawables to GraphicsViews
            circleGraphicsView.Drawable = circleDrawable;
            rectangleGraphicsView.Drawable = rectangleDrawable;
            lineGraphicsView.Drawable = lineDrawable;
            textGraphicsView.Drawable = textDrawable;
            ellipseGraphicsView.Drawable = ellipseDrawable;
            customDrawView.Drawable = customDrawable;
            customPolygonView.Drawable = customPolygon;
            customGradientBackground.Drawable = gradientBackgroundShape;
            customTextWithShadow.Drawable = textWithShadow;
        }
    }

}
