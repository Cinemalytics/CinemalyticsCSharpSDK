using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CinemalyticsCSharpSDK.Model;
using CinemalyticsCSharpSDK.Util;
using Newtonsoft.Json;

namespace CinemalyticsCSharpSDK.Repository
{
    public class DirectorRepository
    {
        private static DirectorRepository _instance;
        private static String _authToken = null;

        private DirectorRepository() { }

        public static DirectorRepository Instance
        {            
            get
            {
                if (_instance == null)
                {
                    _instance = new DirectorRepository();
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
        /// Gets actor by id
        /// </summary>
        /// <param name="directorId"></param>
        /// <returns></returns>
        public Person GetDirectorById(String directorId)
        {
            String url = "http://api.cinemalytics.in/v2/director/id/" + directorId + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Person>(jsonResponse);
        }

        /// <summary>
        /// Gets actor by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Person GetDirectorByName(String name)
        {
            String url = "http://api.cinemalytics.in/v2/director/name/" + name + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Person>(jsonResponse);
        }

        /// <summary>
        /// Get all movies for directorId
        /// </summary>
        /// <param name="directorId"></param>
        /// <returns></returns>
        public List<Movie> GetMoviesForDirectorById(String directorId)
        {
            String url = "http://api.cinemalytics.in/v2/director/" + directorId + "/movies?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }
    }
}
