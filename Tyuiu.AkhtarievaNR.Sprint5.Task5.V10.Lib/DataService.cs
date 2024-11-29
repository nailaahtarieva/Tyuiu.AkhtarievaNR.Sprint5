using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AkhtarievaNR.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader resder = new StreamReader(path))
            {
                
                string line;
                while ((line = resder.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    double[] a = line.Split(' ').Select(double.Parse).ToArray();
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == Math.Truncate(a[i]))
                        {
                            if (a[i] % 2 == 0)
                            {
                                res = res + a[i];
                            }
                        }
                    }
                }

            }
            return res;
        }
    }
}
