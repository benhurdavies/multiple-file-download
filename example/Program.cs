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
            string downloadFile = "http://speedtest.ftp.otenet.gr/files/test1Mb.db";
            var FileDownloader = Factory.GetDownloader(Helper.GetProtocol(downloadFile));
            FileDownloader.Download(downloadFile, @"D:\");

        }
    }
}
