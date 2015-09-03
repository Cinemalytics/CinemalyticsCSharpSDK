using System;
using System.Collections.Generic;
using CinemalyticsCSharpSDK.Model;
using CinemalyticsCSharpSDK.Repository;
using CinemalyticsCSharpSDK.Util;
using Newtonsoft.Json;

namespace CinemalyticsCSharpSDK
{
    public class Cinemalytics
    {
        private static String _authToken = "";

        /// <summary>
        /// Constructs an instance with provided authToken
        /// </summary>
        /// <param name="authToken"></param>
        public Cinemalytics(String authToken)
        {
            _authToken = authToken;
        }

        /// <summary>
        /// Gets the MovieRepository singleton instance. MovieRepository is endpoint for all movie related queries
        /// </summary>
        /// <returns></returns>
        public MovieRepository GetMovieRepositoryInstance()
        {
            MovieRepository mr = MovieRepository.Instance;
            mr.SetAuthToken(_authToken);
            return mr;
        }

    }
}
