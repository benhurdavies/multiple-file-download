using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFileDownloader
{
    public interface IFileDownloader
    {
        void Download(string SrourcePath, string DestinationDirectory, DownloadInfo info = null);
    }
}
