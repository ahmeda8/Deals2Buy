using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Deals2Buy
{
    abstract class BaseWebGet
    {
        protected void MakeGetRequest(string URL)
        {
            HttpWebRequest wr = HttpWebRequest.CreateHttp(URL);
            wr.BeginGetResponse(new AsyncCallback(GetResponse), wr);
        }


        public abstract void GetResponse(IAsyncResult WebResult);
    }
}
