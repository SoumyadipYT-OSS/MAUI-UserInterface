using Microsoft.Maui.Handlers;

namespace CustomControl.Handlers
{
    public interface ICustomCounterButtonHandler : IViewHandler
    {
        void UpdateText(string text);
        void UpdateCount(int count);
    }
}