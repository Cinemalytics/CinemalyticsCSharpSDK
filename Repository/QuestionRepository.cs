using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CinemalyticsCSharpSDK.Model;
using CinemalyticsCSharpSDK.Model.Question;
using CinemalyticsCSharpSDK.Util;
using Newtonsoft.Json;

namespace CinemalyticsCSharpSDK.Repository
{
    public class QuestionRepository
    {
        private static QuestionRepository _instance;
        private static String _authToken = null;

        private QuestionRepository() { }

        public static QuestionRepository Instance
        {            
            get
            {
                if (_instance == null)
                {
                    _instance = new QuestionRepository();
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
        /// <param name="sequenceNumber"></param>
        /// <returns></returns>
        public List<Question> GetQuestions(int sequenceNumber)
        {
            String url = "http://api.cinemalytics.in/v2/question/sequence/" + sequenceNumber + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Question>>(jsonResponse);
        }

        /// <summary>
        /// Gets actor by id
        /// </summary>
        /// <param name="sequenceNumber"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<Question> GetQuestions(int sequenceNumber, int limit)
        {
            String url = "http://api.cinemalytics.in/v2/question/sequence/" + sequenceNumber + "?limit=" + limit + "&auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Question>>(jsonResponse);
        }
    }
}
