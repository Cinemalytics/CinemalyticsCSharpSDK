﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemalyticsCSharpSDK.Model
{
    public class Singer
    {
        public String Id { get; set; }
        public String Name { get; set; }

        private String _profilePath;
        public String ProfilePath
        {
            get { return _profilePath; }
            set { this._profilePath = "https://s3-ap-southeast-1.amazonaws.com/cinemalytics/singer/" + value; }
        }
        public String Gender { get; set; }
    }
}