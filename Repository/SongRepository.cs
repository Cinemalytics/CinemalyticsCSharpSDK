using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CinemalyticsCSharpSDK.Model;
using CinemalyticsCSharpSDK.Util;
using Newtonsoft.Json;

namespace CinemalyticsCSharpSDK.Repository
{
    public class SongRepository
    {
        private static SongRepository _instance;
        private static String _authToken = null;

        private SongRepository() { }

        public static SongRepository Instance
        {            
            get
            {
                if (_instance == null)
                {
                    _instance = new SongRepository();
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
        /// Gets song by id
        /// </summary>
        /// <param name="songId"></param>
        /// <returns></returns>
        public Song GetSongById(String songId)
        {
            String url = "http://api.cinemalytics.in/v2/song/id/" + songId + "?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<Song>(jsonResponse);
        }

        /// <summary>
        /// Gets singers for song
        /// </summary>
        /// <param name="songId"></param>
        /// <returns></returns>
        public List<Singer> GetSingersForSong(String songId)
        {
            String url = "http://api.cinemalytics.in/v2/song/" + songId + "/singers/?auth_token=" + _authToken;
            String jsonResponse = UrlUtil.MakeGetCall(url);

            return JsonConvert.DeserializeObject<List<Singer>>(jsonResponse);
        }
    }
}
