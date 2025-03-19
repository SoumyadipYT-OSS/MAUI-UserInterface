#if ANDROID
using Microsoft.Maui.Handlers;
using Android.Widget;
using Microsoft.Maui.Platform;
using CustomControl.Controls;


namespace CustomControl.Handlers {
    public partial class CustomCounterButtonHandlerAndroid : ViewHandler<CustomCounterButton, Android.Widget.Button> {
        // Define the property mapper
        public readonly static IPropertyMapper<CustomCounterButton, CustomCounterButtonHandlerAndroid> Mapper =
            new PropertyMapper<CustomCounterButton, CustomCounterButtonHandlerAndroid>(ViewHandler.ViewMapper) {
                [nameof(CustomCounterButton.Text)] = MapText,
                [nameof(CustomCounterButton.Count)] = MapCount
            };

        // Pass the mapper to the constructor
        public CustomCounterButtonHandlerAndroid() : base(Mapper) {
        }

        protected override Android.Widget.Button CreatePlatformView() {
            return new Android.Widget.Button(Context);
        }

        protected override void ConnectHandler(Android.Widget.Button platformView) {
            base.ConnectHandler(platformView);
            platformView.Click += OnButtonClick!;
            UpdateText(VirtualView.Text);
            UpdateCount(VirtualView.Count);
        }

        protected override void DisconnectHandler(Android.Widget.Button platformView) {
            platformView.Click -= OnButtonClick!;
            base.DisconnectHandler(platformView);
        }

        private void OnButtonClick(object sender, EventArgs e) {
            VirtualView?.OnTapped(this, e);
        }

        public void UpdateText(string text) {
            PlatformView.Text = text;
        }

        private static void UpdateCount(int count) {
            System.Diagnostics.Debug.WriteLine("Increment Count: " + count);
        }

        public static void MapText(CustomCounterButtonHandlerAndroid handler, CustomCounterButton view) {
            handler.UpdateText(view.Text);
        }

        public static void MapCount(CustomCounterButtonHandlerAndroid handler, CustomCounterButton view) {
            UpdateCount(view.Count);
        }
    }
}
#endif