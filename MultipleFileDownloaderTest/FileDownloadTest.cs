using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultipleFileDownloader;

namespace MultipleFileDownloaderTest
{
    [TestClass]
    public class FileDownloadTest
    {
        [TestMethod]
        public void TestForHttpProtocol()
        {
            string DownloadFile = "http://speedtest.ftp.otenet.gr/files/test1Mb.db";
            var FileDownloader = Factory.GetDownloader(Helper.GetProtocol(DownloadFile));
            Assert.AreEqual(typeof(HttpDownloader), FileDownloader.GetType());
        }

        [TestMethod]
        public void TestForFtpProtocol()
        {
            string DownloadFile = "ftp://speedtest:speedtest@ftp.otenet.gr/test1Mb.db";
            var FileDownloader = Factory.GetDownloader(Helper.GetProtocol(DownloadFile));
            Assert.AreEqual(typeof(FtpDownloader), FileDownloader.GetType());
        }

        [TestMethod]
        public void FileDownloadMockTest()
        {
            string DownloadFile = "http://speedtest.ftp.otenet.gr/files/test1Mb.db";
            var MockWebClient = new MockWebClient();
            var exceptedOutFileName = "d:" + "\\" + Helper.GetFileName(DownloadFile);
            var FileDownloader = Factory.GetDownloader(Helper.GetProtocol(DownloadFile), MockWebClient);
            FileDownloader.Download(DownloadFile, "d:");
            Assert.AreEqual(MockWebClient.DownloadedFileName, exceptedOutFileName);
        }
    }
}
