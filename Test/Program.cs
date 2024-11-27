using System.IO;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double start = 7, end = 9, step = 1;
            string opF = "OutPutFileTask1.txt";
            for (double x = start; x<= end; x += step)
            {
                double res = 2 * x + 3 * Math.Pow(x, 2) - 34;
                if (double.IsInfinity(res) || double.IsNaN(res))
                {
                    res = 0;
                }
                res = Math.Round(res, 2);
                File.AppendAllText(opF, $"{res}\n");
                Console.WriteLine($"{res}");
            }
        }
    }
}
