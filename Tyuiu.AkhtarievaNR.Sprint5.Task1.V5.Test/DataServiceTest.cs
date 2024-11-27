using System.IO;
using Tyuiu.AkhtarievaNR.Sprint5.Task1.V5.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint5.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}