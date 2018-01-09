using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFileDownloader
{
    public class ProxyWebClient : IWebClient
    {
        public ProxyWebClient()
        {
            IWebProxy defaultWebProxy = WebRequest.DefaultWebProxy;
            defaultWebProxy.Credentials = CredentialCache.DefaultCredentials;
            _client = new WebClient { Proxy = defaultWebProxy };
        }
        WebClient _client = null;
        public void DownloadFile(string address, string fileName)
        {
            _client.DownloadFile(address, fileName);
        }
    }
}
