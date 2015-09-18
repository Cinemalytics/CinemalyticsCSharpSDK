﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CinemalyticsCSharpSDK.Model;
using CinemalyticsCSharpSDK.Util;
using Newtonsoft.Json;

namespace CinemalyticsCSharpSDK.Repository
{
    public class AnalyticsRepository
    {
        private static AnalyticsRepository _instance;
        private static String _authToken = null;

        private AnalyticsRepository() { }

        public static AnalyticsRepository Instance
        {            
            get
            {
                if (_instance == null)
                {
                    _instance = new AnalyticsRepository();
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
        /// Gets top rated movies
        /// </summary>        
        /// <returns></returns>
        public List<Movie> GetTopMovies()
        {
            String url = "http://api.cinemalytics.com/v1/analytics/TopMovies/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }

    }
}
