using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CinemalyticsCSharpSDK.Model;
using CinemalyticsCSharpSDK.Util;
using Newtonsoft.Json;

namespace CinemalyticsCSharpSDK.Repository
{
    public class ActorRepository
    {
        private static ActorRepository _instance;
        private static String _authToken = null;

        private ActorRepository() { }

        public static ActorRepository Instance
        {            
            get
            {
                if (_instance == null)
                {
                    _instance = new ActorRepository();
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
        /// <param name="actorId"></param>
        /// <returns></returns>
        public Actor GetActorById(String actorId)
        {
            String url = "http://api.cinemalytics.com/v1/actor/id/" + actorId + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Actor>(jsonResponse);
        }

        /// <summary>
        /// Gets actor by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Actor GetActorByName(String name)
        {
            String url = "http://api.cinemalytics.com/v1/actor/name/" + name + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Actor>(jsonResponse);
        }

        /// <summary>
        /// Get all movies for actorId
        /// </summary>
        /// <param name="actorId"></param>
        /// <returns></returns>
        public List<Movie> GetMoviesForActorById(String actorId)
        {
            String url = "http://api.cinemalytics.com/v1/actor/" + actorId + "/movies?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }


    }
}
