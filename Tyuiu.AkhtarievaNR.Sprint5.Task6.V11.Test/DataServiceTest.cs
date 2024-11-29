using System.IO;
using Tyuiu.AkhtarievaNR.Sprint5.Task6.V11.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint5.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"Ñ:\DataSprint5\InPutDataFileTask6V11.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.AreEqual(true, fileExists);
        }

        [TestMethod]
        public void Count()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V11.txt";
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(3, res);
        }
    }
}