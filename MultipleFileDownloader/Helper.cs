using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFileDownloader
{
    public class Helper
    {
        public static string GetProtocol(string uri)
        {
            return (new Uri(uri)).Scheme;
        }

        public static string GetFileName(string _uri)
        {
            string filename = Path.GetFileName(_uri);
            return GenerateID(_uri) + "_" + filename;
        }

        static string GenerateID(string sourceString)
        {
            return String.Format("{0:X}", sourceString.GetHashCode());
        }
    }
}
