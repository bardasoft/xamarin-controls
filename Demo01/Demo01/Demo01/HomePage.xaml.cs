using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : MasterDetailPage
    {
        public HomePage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as HomePageMenuItem;
            if (item == null)
                return;

            ContentPage page;
            switch (item.Title)
            {
                case "Settings":
                    page = new MainPage();
                    break;
                case "Home":
                default:
                    page = new MainPage();
                    break;
            }
            page.Title = item.Title;
            Detail = new NavigationPage(page)
            {
                BarBackgroundColor = Color.FromHex("#6D27C8"),BarTextColor = Color.White
            };
            IsPresented = false;

            if (Device.RuntimePlatform == "Windows")
            {
                page.Content.GestureRecognizers.Add(new TapGestureRecognizer(view => this.IsPresented = true));
            }

            MasterPage.ListView.SelectedItem = null;
        }
    }
}