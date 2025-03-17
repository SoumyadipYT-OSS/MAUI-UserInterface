using Microsoft.Maui.Handlers;
using _10_ContentView.CustomContentViews;

#if IOS
using UIKit;

namespace _10_ContentView.Handlers
{
    public partial class CustomContentViewHandler : ViewHandler<CustomContentView, UIView>
    {
        public CustomContentViewHandler(IPropertyMapper<CustomContentView, CustomContentViewHandler> mapper, CommandMapper<CustomContentView, CustomContentViewHandler>? commandMapper = null)
            : base(mapper, commandMapper)
        {
        }

        protected override UIView CreatePlatformView() {
            return new UIView();
        }

        public static void MapTitle(CustomContentViewHandler handler, CustomContentView view)
        {
            if (handler.PlatformView != null)
            {
                var label = new UILabel
                {
                    Text = view.Title
                };
                handler.PlatformView.AddSubview(label);
            }
        }

        public static void MapDescription(CustomContentViewHandler handler, CustomContentView view)
        {
            if (handler.PlatformView != null)
            {
                var label = new UILabel
                {
                    Text = view.Description
                };
                handler.PlatformView.AddSubview(label);
            }
        }
    }
}
#endif