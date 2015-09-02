using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemalyticsCSharpSDK
{
    public class Cinemalytics
    {
        private static String AUTH_TOKEN = "";

        /// <summary>
        /// Constructs an instance with provided authToken
        /// </summary>
        /// <param name="authToken"></param>
        public Cinemalytics(String authToken)
        {
            AUTH_TOKEN = authToken;
        }
    }
}
