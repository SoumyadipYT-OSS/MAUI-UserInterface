using Microsoft.Maui.Handlers;
using _10_ContentView.CustomContentViews;


#if ANDROID
using Android.Views;
using Android.Widget;


namespace _10_ContentView.Handlers {
    public partial class CustomContentViewHandler(IPropertyMapper<CustomContentView, CustomContentViewHandler> mapper, CommandMapper<CustomContentView, CustomContentViewHandler>? commandMapper = null) : ViewHandler<CustomContentView, FrameLayout>(mapper, commandMapper) {
        protected override FrameLayout CreatePlatformView() {
            if (MauiContext?.Context == null)
                throw new ArgumentNullException(nameof(MauiContext.Context), "Context cannot be null");

            return new FrameLayout(MauiContext.Context);
        }

        public static void MapTitle(CustomContentViewHandler handler, CustomContentView view) {
            if (handler.PlatformView != null && handler.MauiContext?.Context != null) {
                var textView = new TextView(handler.MauiContext.Context) {
                    Text = view.Title
                };
                handler.PlatformView.AddView(textView);
            }
        }

        public static void MapDescription(CustomContentViewHandler handler, CustomContentView view) {
            if (handler.PlatformView != null && handler.MauiContext?.Context != null) {
                var textView = new TextView(handler.MauiContext.Context) {
                    Text = view.Description
                };
                handler.PlatformView.AddView(textView);
            }
        }
    }
}
#endif