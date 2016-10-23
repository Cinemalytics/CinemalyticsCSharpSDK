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
        public Movie GetMovieById(String movieId)
        {
            String url = "http://api.cinemalytics.in/v2/movie/id/" + movieId + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Movie>(jsonResponse);
        }

        /// <summary>
        /// Gets by title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Movie> GetMovieByTitle(String title)
        {
            String url = " http://api.cinemalytics.in/v2/movie/title/?value=" + title + "&auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }

        /// <summary>
        /// Gets movies by year (release year)
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Movie> GetMoviesByYear(int year)
        {
            String url = " http://api.cinemalytics.in/v2/movie/year/" + year + "/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }

        /// <summary>
        /// Gets movies released this week
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Movie> GetReleasedThisWeekMovies()
        {
            String url = " http://api.cinemalytics.in/v2//movie/releasedthisweek/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }

        /// <summary>
        /// Gets movies getting released on next Thursday/Friday
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Movie> GetNextChangeMovies()
        {
            String url = " http://api.cinemalytics.in/v2//movie/nextchange/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }

        /// <summary>
        /// Gets movies getting released in future
        /// </summary>       
        /// <returns></returns>
        public List<Movie> GetUpcomingMovies()
        {
            String url = " http://api.cinemalytics.in/v2//movie/upcoming/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }

        /// <summary>
        /// Gets all actors who were casted in the movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public List<Person> GetActorsForMovie(String movieId)
        {
            String url = " http://api.cinemalytics.in/v2/movie/" + movieId + "/actors/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Person>>(jsonResponse);
        }

        /// <summary>
        /// Gets all directors for the movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public List<Person> GetDirectorsForMovie(String movieId)
        {
            String url = " http://api.cinemalytics.in/v2/movie/" + movieId + "/directors/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Person>>(jsonResponse);
        }

        /// <summary>
        /// Gets all filming locations for the movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public List<FilmingLocation> GetFilmingLocationsForMovie(String movieId)
        {
            String url = " http://api.cinemalytics.in/v2/movie/" + movieId + "/locations/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<FilmingLocation>>(jsonResponse);
        }        

        /// <summary>
        /// Gets all movies' details with full movie links information for the provided genre
        /// </summary>
        /// <param name="genre"></param>
        /// <returns></returns>
        public List<MovieExtendedWithLinks> GetMoviesWithLinks(String genre)
        {
            String url = " http://api.cinemalytics.in/v2/movie/fullmovies/?genre=" + genre + "&auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<MovieExtendedWithLinks>>(jsonResponse);
        }

        /// <summary>
        /// Gets movie details with full movie links information
        /// </summary>
        /// <param name="id">movie id</param>
        /// <returns></returns>
        public MovieExtendedWithLinks GetMovieWithLinks(String id)
        {
            String url = " http://api.cinemalytics.in/v2/movie/" + id + "/fullmovies/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<MovieExtendedWithLinks>(jsonResponse);
        }

        /// <summary>
        /// Gets latest trailers
        /// </summary>        
        /// <returns></returns>
        public List<Movie> GetLatestTrailers()
        {
            String url = " http://api.cinemalytics.in/v2/movie/latest-trailers/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }

        /// <summary>
        /// Adds rating for the movie
        /// </summary>
        /// <param name="ratingMetaJson"></param>
        /// <returns></returns>
        public String AddRating(String ratingMetaJson)
        {
            String url = " http://api.cinemalytics.in/v2/movie/addrating/?auth_token=" + _authToken;
            return UrlUtil.MakeGetCall(url, ratingMetaJson);            
        }
       
    }
}