namespace _28_RefreshView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

#if IOS
        private async void OnRefresh(object sender, EventArgs e) {
            await System.Threading.Tasks.Task.Delay(2000);

            refreshView.IsRefreshing = false;
        }
#else
        private async void OnRefresh(object sender, EventArgs e) {
            await System.Threading.Tasks.Task.Delay(2000);

            refreshView.IsRefreshing = false;
        }
#endif
    }

}
