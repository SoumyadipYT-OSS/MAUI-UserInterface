using System.Diagnostics;
using System.Text.Json.Serialization;

namespace _15_HybridWebView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            hybridWebView.SetInvokeJavaScriptTarget(this);
        }

        private void OnSendMessageButtonClicked(object sender, EventArgs e) {
            hybridWebView.SendRawMessage($"Hello from C#!");
        }

        private async void OnHybridWebViewRawMessageReceived(object sender, HybridWebViewRawMessageReceivedEventArgs e) {
            await DisplayAlert("Raw Message Received", e.Message, "OK");
            var logBox = (Microsoft.Maui.Controls.Editor)this.FindByName("messageLog");
            logBox.Text += "\r\n" + e.Message;
        }

        private async void OnInvokeAddNumbersClicked(object? sender, EventArgs e) {
            double x = 123d;
            double y = 321d;

            try {
                double result = await hybridWebView.InvokeJavaScriptAsync<double>(
                    "AddNumbers", // JavaScript method name
                    HybridSampleJSContext.Default.Double, // JSON serialization info for return type
                    [ x, y ], // Parameter values
                    [HybridSampleJSContext.Default.Double, HybridSampleJSContext.Default.Double]); // JSON serialization info for each parameter

                await DisplayAlert("Result", $"Result from AddNumbers: {result}", "OK");
            } catch (Exception ex) {
                await DisplayAlert("Error", $"Error invoking JavaScript: {ex.Message}", "OK");
            }
        }

        private async void OnInvokeJavaScriptClicked(object? senddr, EventArgs e) {
            try {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Dictionary<string, string> asyncResult = await hybridWebView.InvokeJavaScriptAsync<Dictionary<string, string>>(
                    "EvaluateMeWithParamsAndAsyncReturn", // JavaScript method name
                    HybridSampleJSContext.Default.DictionaryStringString, // JSON serialization info for return type
                    ["new_key", "new_value"], // Parameter values
                    [HybridSampleJSContext.Default.String, HybridSampleJSContext.Default.String]); // JSON serialization info for each parameter
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                await DisplayAlert("Result", $"Result from EvaluateMeWithParamsAndAsyncReturn: {asyncResult["new_key"]}", "OK");
            } catch (Exception ex) {
                await DisplayAlert("Error", $"Error invoking JavaScript: {ex.Message}", "OK");
            }
        }



        public static void DoSyncWork() {
            Debug.WriteLine("DoSyncWork");
        }

        public static void DoSyncWorkParams(int i, string s) {
            Debug.WriteLine($"DoSyncWorkParams: {i}, {s}");
        }

        public static string DoSyncWorkReturn() {
            Debug.WriteLine("DoSyncWorkReturn");
            return "Hello from C#!";
        }

        public static SyncReturn DoSyncWorkParamsReturn(int i, string s) {
            Debug.WriteLine($"DoSyncWorkParamReturn: {i}, {s}");
            return new SyncReturn {
                Message = "Hello from C#!" + s,
                Value = i
            };
        }

        public class SyncReturn {
            public string? Message { get; set; }
            public int Value { get; set; }
        }
    }

}
