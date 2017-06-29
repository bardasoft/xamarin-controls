using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageMaster : ContentPage
    {
        public ListView ListView;

        public HomePageMaster()
        {
            InitializeComponent();

            BindingContext = new HomePageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class HomePageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomePageMenuItem> MenuItems { get; set; }

            public HomePageMasterViewModel()
            {
                MenuItems = new ObservableCollection<HomePageMenuItem>(new[]
                {
                    new HomePageMenuItem { Title = "Home" , IconUrl = "Home.png"},
                    new HomePageMenuItem { Title = "Settings" ,IconUrl = "Settings.png"}
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}