using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AkhtarievaNR.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(",", "");
                    line = line.Replace(".", "");
                    string[] a = line.Split(' ').ToArray();
                    for (int i = 0; i < a.Length; i++)
                    {
                        string str = a[i];
                        if (str.Length == 6)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
