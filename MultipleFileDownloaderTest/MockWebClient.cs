using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleFileDownloader;

namespace MultipleFileDownloaderTest
{
    class MockWebClient : IWebClient
    {
        string _DownloadedFileName = null;
        public string DownloadedFileName{ get { return _DownloadedFileName; } }
        public void DownloadFile(string address, string fileName)
        {
            _DownloadedFileName = fileName;
        }
    }
}
