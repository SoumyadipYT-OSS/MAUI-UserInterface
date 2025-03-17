using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace _41_WebView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Inject JavaScript once the page loads (performance)
            MyWebView.Navigated += (s, e) => {
                LoadingProgressBar.IsVisible = false;
                LoadingProgressBar.Progress = 0;
            };
        }


        private void OnBackClicked(object sender, EventArgs e) {
            if (MyWebView.CanGoBack) {
                MyWebView.GoBack();
            }
        }

        private void OnForwardClicked(object sender, EventArgs e) {
            if (MyWebView.CanGoForward) {
                MyWebView.GoForward();
            }
        }

        private void OnRefreshClicked(object sender, EventArgs e) {
            MyWebView.Reload();
        }


        private void OnWebViewNavigated(object sender, WebNavigatedEventArgs e) {
            LoadingProgressBar.IsVisible = false;
            LoadingProgressBar.Progress = 1;
        }

        private void OnWebViewNavigating(object sender, WebNavigatingEventArgs e) {
            LoadingProgressBar.IsVisible = true;
            LoadingProgressBar.Progress = 0.2;

            if (e.Url.StartsWith("maui://", StringComparison.OrdinalIgnoreCase)) {
                // Cancel the navigation so the WebView doesn’t try to load this URL
                e.Cancel = true;

                // Extract the message. For example, expect a URL like:
                // "maui://message?data=Hello%20from%20JavaScript"
                try {
                    Uri uri = new(e.Url);
                    // A simple query parser (in absence of System.Web or AspNetCore library)
                    Dictionary<string, string> queryParameters = ParseQuery(uri.Query);

                    if (queryParameters.TryGetValue("data", out string? message)) {
                        // Process the message as needed
                        DisplayAlert("Message from Web", message, "OK");
                    }
                } catch (Exception ex) {
                    DisplayAlert("Parsing Error", ex.Message, "OK");
                }
            }
        }

        // Simple query string parser that splits on '&' and '='.
        private static Dictionary<string, string> ParseQuery(string query) {
            var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            // Remove the initial '?' if present.
            if (query.StartsWith('?'))
                query = query[1..];
            var pairs = query.Split('&', StringSplitOptions.RemoveEmptyEntries);
            foreach (var pair in pairs) {
                var kv = pair.Split('=', 2);
                if (kv.Length == 2) {
                    var key = Uri.UnescapeDataString(kv[0]);
                    var value = Uri.UnescapeDataString(kv[1]);
                    dict[key] = value;
                }
            }
            return dict;
        }
    }
}