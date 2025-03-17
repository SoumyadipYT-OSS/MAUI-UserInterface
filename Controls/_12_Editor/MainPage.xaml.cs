using Editor = Microsoft.Maui.Controls.Editor;

namespace _12_Editor {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            // Set up event handlers in code-behind if needed
            editor.TextChanged += OnEditorTextChanged;
            editor.Completed += OnEditorCompleted;
        }

        private void OnEditorTextChanged(object? sender, TextChangedEventArgs e) {
            if (e.OldTextValue != null && e.NewTextValue != null && sender is Editor editor) {
                string newText = e.NewTextValue;

                // Update the character count
                int textLength = newText.Length;
                charCountLabel.Text = $"{textLength} / 250";

                // Show message if the character limit is reached
                if (textLength >= 250) {
                    charCountLabel.TextColor = Microsoft.Maui.Graphics.Color.Parse("RED");
                    DisplayAlert("Limit Reached", "Character limit of 250 has been reached.", "OK");
                } else {
                    charCountLabel.TextColor = Microsoft.Maui.Graphics.Color.FromRgb(100, 100, 100);
                }
            }
        }

        private void OnEditorCompleted(object? sender, EventArgs e) {
            if (sender is Editor editor) {
                string? text = editor.Text;

                // Example: Display the entered text
                if (text != null) {
                    DisplayAlert("Completed", $"You entered: {text}", "OK");

                    // Example: Save the entered text (pseudo-code for saving to a database or file)
                    // SaveTextToDatabase(text);

                    // Example: Clear the editor after completion
                    editor.Text = string.Empty;
                    charCountLabel.Text = "0 / 250";
                }
            }
        }
    }
}
