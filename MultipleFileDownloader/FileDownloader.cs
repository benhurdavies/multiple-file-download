using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFileDownloader
{
    public class FileDownloader
    {
        public void DownloadFiles(IEnumerable<string> address,string DirectoryPath)
        {
            foreach(var item in address)
            {
                try
                {
                    var FileDownloader = Factory.GetDownloader(Helper.GetProtocol(item));
                    FileDownloader.Download(item, DirectoryPath);
                    Console.WriteLine("Successfully downloaded file from : " + item);
                }catch(Exception e)
                {
                    Console.WriteLine("Failed download file from : " + item+ "; Error msg ("+e.Message+")");
                }
            }
        }
    }
}
