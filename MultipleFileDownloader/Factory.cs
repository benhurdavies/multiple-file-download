using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFileDownloader
{
    public class Factory
    {
        public static IFileDownloader GetDownloader(string type,IWebClient _WebClient=null)
        {
            switch (type)
            {
                case "http": return _WebClient==null ? new HttpDownloader() : new HttpDownloader(_WebClient);
                case "ftp": return new FtpDownloader();
                default: throw new Exception("Not implemented protocol type");
            }
        }
    }
}
