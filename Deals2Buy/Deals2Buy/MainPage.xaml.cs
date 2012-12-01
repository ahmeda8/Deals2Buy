using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Deals2Buy
{
    public partial class MainPage : PhoneApplicationPage
    {
        private ObservableCollection<PivotModel> DataCollection;
        private BackgroundWorker bgw_loader;
        private Deals2Buy d2b;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            if (!Network.IsOnline())
                MessageBox.Show("No internet access available.");
            DataCollection = new ObservableCollection<PivotModel>();
            pvtcontrol.ItemsSource = DataCollection;
            //UpdateData();
            bgw_loader = new BackgroundWorker();
            d2b = new Deals2Buy(DataCollection);
            bgw_loader.DoWork += bgw_loader_DoWork;
            bgw_loader.RunWorkerCompleted += bgw_loader_RunWorkerCompleted;
            pp.IsEnabled = true;
            pp.IsIndeterminate = true;
            d2b.Start();
            bgw_loader.RunWorkerAsync();
        }

        void bgw_loader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pp.IsIndeterminate = false;
            pp.IsEnabled = false;
        }

        void bgw_loader_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!d2b.Completed)
            {   
                System.Threading.Thread.Sleep(2000);
            }
        }

        public void UpdateData()
        {
            Deals2Buy d2b = new Deals2Buy(DataCollection);
            d2b.Start();
            //alldealslist.ItemsSource = DataCollection;
            
        }

        private void alldealslist_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var obj = sender as ListBox;
            if (obj.SelectedIndex > -1)
            {
                ObjectSaver.GetInstance().Set(obj.SelectedItem);
                NavigationService.Navigate(new Uri("/Details.xaml", UriKind.Relative));
            }
        }
    }
}