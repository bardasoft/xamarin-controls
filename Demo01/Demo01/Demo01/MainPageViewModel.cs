using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo01
{
    public class FilterViewModel : BindableObject
    {
        private string _orderType;
        private DateTime? _from = DateTime.Today;
        private DateTime? _to = DateTime.Today.Add(TimeSpan.FromDays(1));

        public string OrderType
        {
            get { return _orderType; }
            set { _orderType = value; OnPropertyChanged(); }
        }

        public DateTime? From
        {
            get { return _from; }
            set { _from = value; OnPropertyChanged(); }
        }

        public DateTime? To
        {
            get { return _to; }
            set { _to = value; OnPropertyChanged(); }
        }
    }
    public class MainPageViewModel:BindableObject
    {
        private FilterViewModel _filter = new FilterViewModel();

        public FilterViewModel Filter
        {
            get { return _filter; }
            set { _filter = value;OnPropertyChanged(); }
        }

        public ICommand Search { get; private set; }

        public List<string> OrderTypes { get; private set; } = new List<string>()
        {
            "Bussines","Customer","Other"
        };

        public MainPageViewModel()
        {
            Search = new Command(()=> OnPropertyChanged("Filter"));
        }
    }
}
