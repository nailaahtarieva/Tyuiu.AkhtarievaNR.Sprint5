using Tyuiu.AkhtarievaNR.Sprint5.Task0.V26.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint5.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Ахтариева Н. Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание: 0                                                              *");
            Console.WriteLine("* Вариант: 26                                                             *");
            Console.WriteLine("* Выполнила: Ахтариева Наиля Руслановна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение выражения, результат     *");
            Console.WriteLine("* сохраняет в текстовый файл и выводит его на консоль.                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.Write("Файл:" + res);
            Console.Write(" Создан!");
            Console.ReadKey();
        }
    }
}
