using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleFileDownloader;

namespace example
{
    public class Program
    {
        public static void Main()
        {
            //file download 
            string downloadFile1 = "http://speedtest.ftp.otenet.gr/files/test1Mb.db";
            string downloadFile2 = "http://speedtest.ftp.otenet.gr/files/test100k.db";
            FileDownloader fileDownload = new FileDownloader();
            fileDownload.DownloadFiles(new string[] { downloadFile1, downloadFile2 }, "d:");

        }
    }
}
