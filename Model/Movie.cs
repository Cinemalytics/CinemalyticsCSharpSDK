using System;

namespace CinemalyticsCSharpSDK.Model
{
    public class Movie
    {
        public int Id { get; set; }        
        public String ImdbId { get; set; }
        public String OriginalTitle { get; set; }
        public String Title { get; set; }
        public String Country { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public long Budget { get; set; }
        public long Revenue { get; set; }

        private String _posterPath;
        public String PosterPath
        {
            get { return _posterPath; }
            set { this._posterPath = "https://s3-ap-southeast-1.amazonaws.com/cinemalytics/movie/" + value; }
        } 
    }
}