using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CinemalyticsCSharpSDK.Model;
using CinemalyticsCSharpSDK.Util;
using Newtonsoft.Json;

namespace CinemalyticsCSharpSDK.Repository
{
    public class PersonRepository
    {
        private static PersonRepository _instance;
        private static String _authToken = null;

        private PersonRepository() { }

        public static PersonRepository Instance
        {            
            get
            {
                if (_instance == null)
                {
                    _instance = new PersonRepository();
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
        /// Gets person by id
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public Person GetPersonById(String personId)
        {
            String url = "http://api.cinemalytics.in/v2/person/id/" + personId + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Person>(jsonResponse);
        }

        /// <summary>
        /// Gets person by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Person> GetPersonByName(String name)
        {
            String url = "http://api.cinemalytics.in/v2/person/name/" + name + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Person>>(jsonResponse);
        }

        /// <summary>
        /// Adds rating for the person
        /// </summary>
        /// <param name="ratingMetaJson"></param>
        /// <returns></returns>
        public String AddRating(String ratingMetaJson)
        {
            String url = "http://api.cinemalytics.in/v2/person/addrating/?auth_token=" + _authToken;
            return UrlUtil.MakeGetCall(url, ratingMetaJson);
        }
    
    }
}
