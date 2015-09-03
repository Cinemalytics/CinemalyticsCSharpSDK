using System;
using System.Collections.Generic;
using CinemalyticsCSharpSDK.Model;
using CinemalyticsCSharpSDK.Util;
using Newtonsoft.Json;

namespace CinemalyticsCSharpSDK.Repository
{
    public class MovieRepository
    {
        private static MovieRepository _instance;

        private static String _authToken = null;

        private MovieRepository() { }

        public static MovieRepository Instance
        {            
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieRepository();
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
        /// Gets movie by id
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public Movie GetMovieById(int movieId)
        {
            String url = "http://api.cinemalytics.com/v1/movie/id/" + movieId + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Movie>(jsonResponse);
        }

        /// <summary>
        /// Gets movie by title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public Movie GetMovieByTitle(String title)
        {
            String url = " http://api.cinemalytics.com/v1/movie/title/" + title + "/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Movie>(jsonResponse);
        }

        /// <summary>
        /// Gets movies by year (release year)
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Movie> GetMoviesByYear(int year)
        {
            String url = " http://api.cinemalytics.com/v1/movie/year/" + year + "/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }

        /// <summary>
        /// Gets all actors who were casted in the movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public List<Actor> GetActorsForMovie(int movieId)
        {
            String url = " http://api.cinemalytics.com/v1/movie/" + movieId + "/actors/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Actor>>(jsonResponse);
        }

        /// <summary>
        /// Gets all directors for the movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public List<Director> GetDirectorsForMovie(int movieId)
        {
            String url = " http://api.cinemalytics.com/v1/movie/" + movieId + "/directors/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Director>>(jsonResponse);
        }

        /// <summary>
        /// Gets all filming locations for the movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public List<FilmingLocation> GetFilmingLocationsForMovie(int movieId)
        {
            String url = " http://api.cinemalytics.com/v1/movie/" + movieId + "/locations/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<FilmingLocation>>(jsonResponse);
        } 
    }
}