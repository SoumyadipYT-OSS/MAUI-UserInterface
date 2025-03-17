using Microsoft.Maui.Controls;

namespace _10_ContentView.CustomContentViews {
    public partial class CustomContentView : ContentView {
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(CustomContentView), string.Empty);

        public static readonly BindableProperty DescriptionProperty =
            BindableProperty.Create(nameof(Description), typeof(string), typeof(CustomContentView), string.Empty);

        public string Title {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public string Description {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }

        public CustomContentView() {
            InitializeComponent();
        }
    }
}
