// CustomCounterButton.cs
using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace CustomControl.Controls {

    public partial class CustomCounterButton : View {
        // Bindable Property for the Text
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomCounterButton), "Click Me",
                propertyChanged: OnTextChanged);

        // Bindable Property for the Count
        public static readonly BindableProperty CountProperty =
            BindableProperty.Create(nameof(Count), typeof(int), typeof(CustomCounterButton), 0);

        // Event for Click
        public event EventHandler Clicked;

        // Command Property
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(CustomCounterButton), null);

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public CustomCounterButton() {
            // Make the control tappable
            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += OnTapped!;
            GestureRecognizers.Add(tapGesture);
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        // Public properties
        public string Text {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public int Count {
            get => (int)GetValue(CountProperty);
            set => SetValue(CountProperty, value);
        }

        public ICommand Command {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        // Handler for tap gesture
        public void OnTapped(object sender, EventArgs e) {
            Count++;
            Clicked?.Invoke(this, EventArgs.Empty);
            Command?.Execute(Count);
        }

        // Text property changed handler
        private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue) {
            var control = (CustomCounterButton)bindable;
            // Here you can add logic when text changes
            control.Text = "Text Changed";
            System.Diagnostics.Debug.WriteLine("Text changed properly.");
        }
    }
}