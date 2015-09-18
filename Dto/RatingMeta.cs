using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemalyticsCSharpSDK.Dto
{
    public class RatingMeta
    {
        public String MovieId { get; set; }
        public String Rating { get; set; }

        public RatingMeta(String movieId, String rating)
        {
            MovieId = movieId;
            Rating = rating;
        }
    }
}
