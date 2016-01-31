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
        public Director GetDirectorById(String directorId)
        {
            String url = "https://api.cinemalytics.com/v1/director/id/" + directorId + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Director>(jsonResponse);
        }

        /// <summary>
        /// Gets actor by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Director GetDirectorByName(String name)
        {
            String url = "https://api.cinemalytics.com/v1/director/name/" + name + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Director>(jsonResponse);
        }

        /// <summary>
        /// Get all movies for directorId
        /// </summary>
        /// <param name="directorId"></param>
        /// <returns></returns>
        public List<Movie> GetMoviesForDirectorById(String directorId)
        {
            String url = "https://api.cinemalytics.com/v1/director/" + directorId + "/movies?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }
    }
}
