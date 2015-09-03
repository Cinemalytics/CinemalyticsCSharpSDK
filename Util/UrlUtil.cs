using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CinemalyticsCSharpSDK.Util
{
    internal class UrlUtil
    {
        public static String MakeGetCall(String url)
        {       
            var req = (HttpWebRequest) WebRequest.Create(url);
            Stream responseStream = ((HttpWebResponse) req.GetResponse()).GetResponseStream();

            if (responseStream == null)
            {
                return "{}";
            }

            StreamReader streamReader = new StreamReader(responseStream);
            return streamReader.ReadToEnd();
        }
    }
}
