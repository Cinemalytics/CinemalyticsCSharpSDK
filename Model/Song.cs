using System;

namespace CinemalyticsCSharpSDK.Model
{
    public class Song
    {
        public String Id { get; set; }
        public String Title { get; set; }
        public float Duration { get; set; }
        public short IsFinal { get; set; }
        public String YouTubeVideoId { get; set; }
        public String YouTubeLink { get; set; }
        public String YouTubeEmbed { get; set; }
    }
}
