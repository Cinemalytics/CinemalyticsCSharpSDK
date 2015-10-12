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
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 10000;
            Stream responseStream = ((HttpWebResponse)request.GetResponse()).GetResponseStream();

            if (responseStream == null)
            {
                return "{}";
            }

            StreamReader streamReader = new StreamReader(responseStream);
            return streamReader.ReadToEnd();
        }

        public static String MakeGetCall(String url, String postData)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 10000;

            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            if (responseStream == null)
            {
                return "{}";
            }

            StreamReader streamReader = new StreamReader(responseStream);
            return streamReader.ReadToEnd();
        }
    }
}
