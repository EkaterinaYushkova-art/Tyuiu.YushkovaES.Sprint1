using Tyuiu.YushkovaES.Sprint1.Task4.V22.Lib;

namespace Tyuiu.YushkovaES.Sprint1.Task0.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Екатерина Е. С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Class Math                                                       *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #22                                                            *");
            Console.WriteLine("* Выполнил: Екатерина Е. С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные *");
            Console.WriteLine("* вычисляет результаты по формуле и печатает его на экране               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x, y;
            Console.Write("Введите значение x: ");

            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Ответ выражения = " + ds.Calculate(x, y));
            Console.ReadKey();


        }
    }
}