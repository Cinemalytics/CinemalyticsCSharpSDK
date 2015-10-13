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

            using (var response = request.GetResponse())
            {
                Stream responseStream = ((HttpWebResponse)response).GetResponseStream();

                if (responseStream == null)
                {
                    return "{}";
                }
                StreamReader streamReader = new StreamReader(responseStream);
                String responseJson = streamReader.ReadToEnd();
                streamReader.Close();
                return responseJson;
            }
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

            using (var response = request.GetResponse())
            {
                Stream responseStream = ((HttpWebResponse)response).GetResponseStream();

                if (responseStream == null)
                {
                    return "{}";
                }
                StreamReader streamReader = new StreamReader(responseStream);
                String responseJson = streamReader.ReadToEnd();
                streamReader.Close();
                return responseJson;
            }
        }
    }
}
