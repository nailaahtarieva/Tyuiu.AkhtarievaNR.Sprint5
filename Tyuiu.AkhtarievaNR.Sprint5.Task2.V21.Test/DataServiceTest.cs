using System.IO;
using Tyuiu.AkhtarievaNR.Sprint5.Task2.V21.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint5.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}