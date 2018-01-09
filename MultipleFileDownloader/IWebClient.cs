using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFileDownloader
{
    public interface IWebClient
    {
        void DownloadFile(string address, string fileName);
    }
}
