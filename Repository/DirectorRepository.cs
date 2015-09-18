using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemalyticsCSharpSDK.Repository
{
    public class DirectorRepository
    {
        private static DirectorRepository _instance;
        private static String _authToken = null;

        private DirectorRepository() { }

        public static DirectorRepository Instance
        {            
            get
            {
                if (_instance == null)
                {
                    _instance = new DirectorRepository();
                }
                return _instance;                
            }
        }

        internal void SetAuthToken(String authToken)
        {
            if (String.IsNullOrEmpty(_authToken))
            {
                _authToken = authToken;
            }
        }
    }
}
