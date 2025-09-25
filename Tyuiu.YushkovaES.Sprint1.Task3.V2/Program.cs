using Tyuiu.YushkovaES.Sprint1.Task3.V2.Lib;

namespace Tyuiu.YushkovaES.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Екатерина Е. С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Екатерина Е. С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите цену тетради:");
            double notebookPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество тетрадей:");
            int notebookQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите цену карандаша:");
            double pencilPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество карандашей:");
            int pencilQuantity = int.Parse(Console.ReadLine());

            double totalCost = (notebookPrice * notebookQuantity) + (pencilPrice * pencilQuantity);



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"Общая стоимость покупки: {totalCost:F3} руб.");

            Console.ReadKey();



        }
    }
}

