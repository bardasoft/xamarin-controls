using Xamarin.Forms;

namespace Demo02
{
    public partial class HomePage : ContentPage
    {
        public HomePage(string url)
        {
            InitializeComponent();
            WebView.Source = new UrlWebViewSource(){Url = url};
        }

        private void WebView_OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            Loader.IsVisible = false;
        }

        private void WebView_OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            Loader.IsVisible = true;
        }
    }
}