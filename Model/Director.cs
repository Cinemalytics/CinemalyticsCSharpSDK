using System;

namespace CinemalyticsCSharpSDK.Model
{
    public class Director
    {
        public String Id { get; set; }        
        public String Name { get; set; }
        public String Gender { get; set; }

        private String _profilePath;
        public String ProfilePath
        {
            get { return _profilePath; }
            set { this._profilePath = "https://s3-ap-southeast-1.amazonaws.com/cinemalytics/director/" + value; }
        }

        public String DateOfBirth { get; set; }
        public String BirthPlace { get; set; }
        public String OfficialWebsite { get; set; }
        public String OfficialFacebookPage { get; set; }
        public String OfficialTwitterPage { get; set; }
    }
}
