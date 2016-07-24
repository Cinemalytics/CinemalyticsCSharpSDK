using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CinemalyticsCSharpSDK.Model;
using CinemalyticsCSharpSDK.Util;
using Newtonsoft.Json;

namespace CinemalyticsCSharpSDK.Repository
{
    public class SingerRepository
    {
        private static SingerRepository _instance;
        private static String _authToken = null;

        private SingerRepository() { }

        public static SingerRepository Instance
        {            
            get
            {
                if (_instance == null)
                {
                    _instance = new SingerRepository();
                }
                return _instance;                
            }
        }

        internal void SetAuthToken(String authToken)
        {
            if (String.IsNullOrEmpty(_authToken))
            {
                _authToken = authToken;
            }
        }

        /// <summary>
        /// Gets singer by id
        /// </summary>
        /// <param name="singerId"></param>
        /// <returns></returns>
        public Singer GetSingerById(String singerId)
        {
            String url = "http://api.cinemalytics.in/v2/singer/id/" + singerId + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Singer>(jsonResponse);
        }

    }
}
