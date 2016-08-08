using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemalyticsCSharpSDK.Dto
{
    public class RatingMovieMeta
    {
        public String UserId { get; set; }
        public String MovieId { get; set; }
        public String Rating { get; set; }

        public RatingMovieMeta(String userId, String movieId, String rating)
        {
            UserId = userId;
            MovieId = movieId;
            Rating = rating;
        }
    }
}
