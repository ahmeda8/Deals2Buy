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
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();
            string tx1 = "Deals2Buy is a registered trademark of WhaleShark Media, Inc. " + Environment.NewLine
                        +"Unless otherwise indicated, all other trademarks are the property of "
                        +"their respective owners and are not affiliated with Deals2Buy or WhaleShark Media, Inc. " + Environment.NewLine
                        +"Nor is this App affiliated to WhaleShark Media, Inc ";
            txt1.Text = tx1;
        }

        private void emailBtn_Click_1(object sender, RoutedEventArgs e)
        {
            EmailComposeTask ect = new EmailComposeTask();
            ect.Subject = "Query from deals2buy App";
            ect.To = "ahmed_abrar@live.com";
            ect.Show();
        }
    }
}