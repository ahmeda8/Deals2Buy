using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Deals2Buy
{
    public class PivotModel : BaseModel
    {
        private string _Header;
        public string Header
        {
            get { return _Header; }
            set
            {
                _Header = value;
                NotifyPropertyChanged("Header", this);
            }
        }

        private string _Url;
        public string Url
        {
            get { return _Url; }
            set
            {
                _Url = value;
                NotifyPropertyChanged("Url", this);
            }
        }

        private ObservableCollection<DisplayModel> _DataCollection;
        public ObservableCollection<DisplayModel> DataCollection
        {
            get { return _DataCollection; }
            set
            {
                _DataCollection = value;
                NotifyPropertyChanged("DataCollection", this);
            }
        }
    }
}
