using Tyuiu.YushkovaES.Sprint1.Task2.V5.Lib;

namespace Tyuiu.YushkovaES.Sprint1.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Екатерина Е. С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                    *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил: Екатерина Е. С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Известна длина стороны куба                                            *");
            Console.WriteLine("* Вычислить площадь боковой поверхности куба.                            *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
           

            int x;
            Console.WriteLine("Введите значение X:"); 
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Квадрат числа X = " + ds.CalculateSideSquare(x));
            Console.ReadLine();

        }
    }
}
