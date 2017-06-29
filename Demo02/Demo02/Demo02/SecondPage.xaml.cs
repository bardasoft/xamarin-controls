using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
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