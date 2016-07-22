using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemalyticsCSharpSDK.Model
{
    public class MovieReview
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
