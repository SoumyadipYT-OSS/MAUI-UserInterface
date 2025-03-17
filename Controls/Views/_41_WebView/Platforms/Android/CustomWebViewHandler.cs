#if ANDROID
using global::Android.Webkit;  // Explicitly reference the global Android.Webkit namespace
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace _41_WebView.Platforms.Android {
    public class CustomWebViewHandler : WebViewHandler {
        protected override void ConnectHandler(global::Android.Webkit.WebView nativeView) {
            base.ConnectHandler(nativeView);

            if (nativeView?.Settings != null) {
                // Enable JavaScript
                nativeView.Settings.JavaScriptEnabled = true;

                // Enable a wide viewport to allow the content to scale properly
                nativeView.Settings.UseWideViewPort = true;

                // Ensure content fits the screen by default
                nativeView.Settings.LoadWithOverviewMode = true;
            }
        }
    }
}
#endif