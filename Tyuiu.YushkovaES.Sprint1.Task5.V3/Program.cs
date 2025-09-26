using Tyuiu.YushkovaES.Sprint1.Task5.V3.Lib;

namespace Tyuiu.YushkovaES.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Екатерина Е. С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                       *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнил: Екатерина Е. С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Присвоить целой переменной h третью от конца цифру                     *");
            Console.WriteLine("* в записи положительного целого числа k                                 *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            Console.Write("Введите положительное число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            int res = Convert.ToInt32(ds.Calculate(x));
            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}

