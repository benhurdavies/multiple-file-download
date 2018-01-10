using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MultipleFileDownloader
{
    public class HttpDownloader : IFileDownloader
    {
        public HttpDownloader()
        {
            client =new ProxyWebClient();
        }
        public HttpDownloader(IWebClient _client)
        {
            client = _client;
        }

        IWebClient client = null;
        public void Download(string SrourcePath, string DestinationDirectory, DownloadInfo info = null)
        {
            try
            {
                client.DownloadFile(SrourcePath, DestinationDirectory + "\\" + Helper.GetFileName(SrourcePath));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
