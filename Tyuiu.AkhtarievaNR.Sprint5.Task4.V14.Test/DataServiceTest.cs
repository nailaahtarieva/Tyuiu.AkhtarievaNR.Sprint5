using System.IO;
using Tyuiu.AkhtarievaNR.Sprint5.Task4.V14.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint5.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"Ñ:\DataSprint5\InPutDataFileTask4V21.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}