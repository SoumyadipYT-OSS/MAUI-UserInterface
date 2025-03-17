namespace _13_Entry
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Setting teh Entry under Constructor of the class
            Microsoft.Maui.Controls.Entry entry = new Microsoft.Maui.Controls.Entry { Placeholder = "Enter text" };
            entry.TextChanged += OnEntryTextChanged;
            entry.Completed += OnEntryCompleted;
        }


        private void OnEntryTextChanged(object? sender, TextChangedEventArgs e) {
            _ = e.OldTextValue;
            _ = e.NewTextValue;
            _ = entry.Text;
        }

        private void OnEntryCompleted(object? sender, EventArgs e) {
            if (sender is Entry entry  &&  entry.Text != null) {
                string text = entry.Text;

                DisplayAlert("Completed", $"You entered: {text}", "OK");
            }
        }
    }

}
