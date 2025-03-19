#if IOS
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using UIKit;
using CustomControl.Controls;

namespace CustomControl.Handlers
{
    public partial class CustomCounterButtonHandler_ios : ViewHandler<CustomCounterButton, UIButton>
    {
        // Define the property mapper
        public readonly static IPropertyMapper<CustomCounterButton, CustomCounterButtonHandler_ios> Mapper =
            new PropertyMapper<CustomCounterButton, CustomCounterButtonHandler_ios>(ViewHandler.ViewMapper)
            {
                [nameof(CustomCounterButton.Text)] = MapText,
                [nameof(CustomCounterButton.Count)] = MapCount
            };

        // Pass the mapper to the constructor
        public CustomCounterButtonHandler_ios() : base(Mapper)
        {
        }

        protected override UIButton CreatePlatformView()
        {
            return new UIButton(UIButtonType.System);
        }

        protected override void ConnectHandler(UIButton platformView)
        {
            base.ConnectHandler(platformView);
            platformView.TouchUpInside += OnButtonTouch!;
            UpdateText(VirtualView.Text);
            UpdateCount(VirtualView.Count);
        }

        protected override void DisconnectHandler(UIButton platformView)
        {
            platformView.TouchUpInside -= OnButtonTouch!;
            base.DisconnectHandler(platformView);
        }

        private void OnButtonTouch(object sender, EventArgs e)
        {
            VirtualView?.OnTapped(this, e);
        }

        public void UpdateText(string text)
        {
            PlatformView.SetTitle(text, UIControlState.Normal);
        }

        private static void UpdateCount(int count)
        {
            // iOS doesn't need count display, but we could modify the title if needed
            System.Diagnostics.Debug.WriteLine("iOS Count Updated: " + count);
        }

        public static void MapText(CustomCounterButtonHandler_ios handler, CustomCounterButton view)
        {
            handler.UpdateText(view.Text);
        }

        public static void MapCount(CustomCounterButtonHandler_ios handler, CustomCounterButton view)
        {
            UpdateCount(view.Count);
        }
    }
}
#endif