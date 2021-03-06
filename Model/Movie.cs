﻿using System;

namespace CinemalyticsCSharpSDK.Model
{
    public class Movie
    {
        public String Id { get; set; }
        public String ImdbId { get; set; }
        public String OriginalTitle { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String TrailerLink { get; set; }
        public String TrailerEmbedCode { get; set; }
        public String Country { get; set; }
        public String Region { get; set; }
        public String Genre { get; set; }
        public int RatingCount { get; set; }
        public float Rating { get; set; }
        public String CensorRating { get; set; }
        public String ReleaseDate { get; set; }
        public int ReleaseYear { get; set; }        
        public int Runtime { get; set; }
        public long Budget { get; set; }
        public long Revenue { get; set; }
        public String PosterPath { get; set; }
        public String LastUpdateTime { get; set; }
        public int TotalCriticReviews { get; set; }
    }
}