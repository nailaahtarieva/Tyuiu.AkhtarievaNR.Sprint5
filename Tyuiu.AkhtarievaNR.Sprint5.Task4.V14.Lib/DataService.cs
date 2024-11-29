using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AkhtarievaNR.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string srt = File.ReadAllText(path);
            string s = srt.Replace(".", ",");
            string strX = File.ReadAllText(s);
            double res = Math.Round(Math.Sin(Math.Pow(Convert.ToDouble(strX), 3)) + (2 / Convert.ToDouble(strX)),3); 
            return res;

        }
    }
}
