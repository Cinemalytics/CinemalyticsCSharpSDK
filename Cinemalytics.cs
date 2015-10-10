using System;
using CinemalyticsCSharpSDK.Repository;

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

        /// <summary>
        /// Gets the PersonRepository singleton instance. PersonRepository is endpoint for all person related queries
        /// </summary>
        /// <returns></returns>
        public PersonRepository GetPersonRepositoryInstance()
        {
            PersonRepository pr = PersonRepository.Instance;
            pr.SetAuthToken(_authToken);
            return pr;
        }

        /// <summary>
        /// Gets the ActorRepository singleton instance. ActorRepository is endpoint for all actor related queries
        /// </summary>
        /// <returns></returns>
        public ActorRepository GetActorRepositoryInstance()
        {
            ActorRepository ar = ActorRepository.Instance;
            ar.SetAuthToken(_authToken);
            return ar;
        }

        /// <summary>
        /// Gets the DirectorRepository singleton instance. DirectorRepository is endpoint for all director related queries
        /// </summary>
        /// <returns></returns>
        public DirectorRepository GetDirectorRepositoryInstance()
        {
            DirectorRepository dr = DirectorRepository.Instance;
            dr.SetAuthToken(_authToken);
            return dr;
        }

        /// <summary>
        /// Gets the SongRepository singleton instance. SongRepository is endpoint for all song related queries
        /// </summary>
        /// <returns></returns>
        public SongRepository GetSongRepositoryInstance()
        {
            SongRepository sr = SongRepository.Instance;
            sr.SetAuthToken(_authToken);
            return sr;
        }

        /// <summary>
        /// Gets the SingerRepository singleton instance. SingerRepository is endpoint for all singer related queries
        /// </summary>
        /// <returns></returns>
        public SingerRepository GetSingerRepositoryInstance()
        {
            SingerRepository sr = SingerRepository.Instance;
            sr.SetAuthToken(_authToken);
            return sr;
        }

        /// <summary>
        /// Gets the AnalyticsRepository singleton instance. AnalyticsRepository is endpoint for all cinema analytics related queries
        /// </summary>
        /// <returns></returns>
        public AnalyticsRepository GetAnalyticsRepositoryInstance()
        {
            AnalyticsRepository ar = AnalyticsRepository.Instance;
            ar.SetAuthToken(_authToken);
            return ar;
        }
    }
}
