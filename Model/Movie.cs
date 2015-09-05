using System;

namespace CinemalyticsCSharpSDK.Model
{
    public class Movie
    {
        public String Id { get; set; }
        public String ImdbId { get; set; }
        public String OriginalTitle { get; set; }
        public String Title { get; set; }
        public String Country { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public long Budget { get; set; }
        public long Revenue { get; set; }
        public String PosterPath { get; set; }
    }
}