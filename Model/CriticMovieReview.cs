using System;

namespace CinemalyticsCSharpSDK.Model
{
    public class CriticMovieReview
    {
        public int Id { get; set; }
        public String MovieId { get; set; }
        public String CriticId { get; set; }
        public int OrgId { get; set; }
        public String Excerpt { get; set; }
        public float Rating { get; set; }
        public String Link { get; set; }
    }
}
