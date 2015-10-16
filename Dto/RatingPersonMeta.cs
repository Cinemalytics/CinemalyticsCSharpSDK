using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemalyticsCSharpSDK.Dto
{
    public class RatingPersonMeta
    {
        public String PersonId { get; set; }
        public String Rating { get; set; }

        public RatingPersonMeta(String personId, String rating)
        {
            PersonId = personId;
            Rating = rating;
        }
    }
}
