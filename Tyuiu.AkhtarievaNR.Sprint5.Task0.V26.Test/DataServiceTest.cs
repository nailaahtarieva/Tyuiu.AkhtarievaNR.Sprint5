using System.Diagnostics;
using System.IO;
using Tyuiu.AkhtarievaNR.Sprint5.Task0.V26.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint5.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            int x = 2;
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}