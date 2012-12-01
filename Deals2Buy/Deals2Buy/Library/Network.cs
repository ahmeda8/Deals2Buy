using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Phone.Net.NetworkInformation;

namespace Deals2Buy
{
    class Network
    {
        public static bool IsOnline()
        {
#if DEBUG
            return true;
#else
            return NetworkInterface.GetIsNetworkAvailable();
#endif
        }
    }
}
