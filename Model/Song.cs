using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemalyticsCSharpSDK.Model
{
    public class Song
    {
        public String Id { get; set; }
        public String Title { get; set; }
        public float Duration { get; set; }
        public short IsFinal { get; set; }
    }
}
