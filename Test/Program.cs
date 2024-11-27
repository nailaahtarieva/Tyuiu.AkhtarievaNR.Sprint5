using System.IO;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 6, 9, 4 }, { 7, 2, 4 }, { 4, 8, 3 } };
            int rowSum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[1, j];
            }
            File.WriteAllText("OutPutFileTask2.csv", rowSum.ToString());
        }
    }
}
