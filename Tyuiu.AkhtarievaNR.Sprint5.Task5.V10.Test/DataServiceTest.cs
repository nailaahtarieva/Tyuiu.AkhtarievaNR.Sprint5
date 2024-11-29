using System.IO;
using Tyuiu.AkhtarievaNR.Sprint5.Task5.V10.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint5.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"Ñ:\DataSprint5\InPutDataFileTask5V10.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}