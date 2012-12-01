using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace Deals2Buy
{
    public partial class Details : PhoneApplicationPage
    {
        public Details()
        {
            InitializeComponent();
            DataContext = ObjectSaver.GetInstance().Get();
        }

        private void appbar_web_Click_1(object sender, EventArgs e)
        {
            DisplayModel dm = ObjectSaver.GetInstance().Get() as DisplayModel;
            WebBrowserTask wbt = new WebBrowserTask();
            wbt.Uri = new Uri(dm.Link,UriKind.Absolute);
            wbt.Show();
        }

        
        private void appbar_email_Click_1(object sender, EventArgs e)
        {
            DisplayModel dm = ObjectSaver.GetInstance().Get() as DisplayModel;
            EmailComposeTask ect = new EmailComposeTask();
            ect.Subject = "Check out this deal";
            ect.Body = "I found this deal at Deals2Buy " + Environment.NewLine + Environment.NewLine
                + dm.Title + Environment.NewLine + Environment.NewLine
                + dm.Date + Environment.NewLine + Environment.NewLine
                + dm.Desc + Environment.NewLine + Environment.NewLine
                +"More Info here -> "
                + dm.Link + Environment.NewLine + Environment.NewLine + "Deals2Buy Windows Phone App";
            ect.Show();
        }
    }
}