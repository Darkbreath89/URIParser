using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URIParser
{
    class UriParser
    {
        public UriComponents comp;

        private Uri uri;
        // This boolean tracks if the URI is valid upon creation. 
        // At the moment it isn't really needed, but it could be used
        // as a way to let the caller know if the URI passed was valid.
        private bool isValid;

        /// <summary>
        /// Constructor for the UriParse class. Takes the URI as an input.
        /// If the URI is not malformed it calls the SetComponents method.
        /// If it is malformed it calls the InformCallerForMalformation method
        /// that handles informing the caller that the URI passed was malformed.
        /// </summary>
        /// <param name="uriString"> The URI</param>
        public UriParser(string uriString)
        {
            comp = new UriComponents();
            try
            {
                uri = new Uri(uriString);
                isValid = true;
            }
            catch (System.UriFormatException e)
            {
                isValid = false;
            }

            if (isValid)
            {
                SetComponents();
            }
            else
            {
                InformCallerForMalformation(uriString);
            }
        }

        /// <summary>
        /// Creates an instance of the custom UriComponents class and populates it's values.
        /// </summary>
        private void SetComponents()
        {
            comp.scheme = uri.Scheme;
            comp.fragment = uri.Fragment;
            comp.host = uri.Host;

            //path and query. Comes in two parts could probably be saved as it comes
            //and let the caller handle it, depends on the specifications. This way is dirty.
            string[] tempPathAndQuery = uri.PathAndQuery.Split('?');
            comp.path = tempPathAndQuery[0];
            if (tempPathAndQuery.Length > 1) comp.query = tempPathAndQuery[1];

            //user info. Comes in two parts could probably be saved as it comes
            //and let the caller handle it, depends on the specifications. This way is dirty.
            string[] tempUserInfo = uri.UserInfo.Split(':');
            comp.user = tempUserInfo[0];
            if (tempUserInfo.Length > 1) comp.password = tempUserInfo[1];

            //port is an int could also be passed around as a string if preffered.
            comp.port = uri.Port;
        }

        /// <summary>
        /// Used to inform the caller that the URI passed was malformed.
        /// Currently it only outputs to console. While this doesn't inform directly
        /// the caller, it could be changed to whatever is needed or the isValid boolean could
        /// be used instead. Again depends on the needs and specifications.
        /// </summary>
        /// <param name="uriProvided"></param>
        private void InformCallerForMalformation(string uriProvided)
        {
            Console.WriteLine("URI : " + uriProvided + " that was provided is malformed.");
        }
    }
}
