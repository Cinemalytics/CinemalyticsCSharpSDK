using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemalyticsCSharpSDK.Model
{
    public class FilmingLocation
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        internal bool IsStudio { get; set; }   
    }
}
