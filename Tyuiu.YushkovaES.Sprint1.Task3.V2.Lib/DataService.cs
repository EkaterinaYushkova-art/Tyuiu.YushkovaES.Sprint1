using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.YushkovaES.Sprint1.Task3.V2.Lib
{
    public class DataService : ISprint1Task3V2
    {
        public double PurchaseAmount(double notebookPrice, int notebookQuantity,
                                   double pencilPrice, int pencilQuantity)
        {
            // Правильный расчет: цена * количество
            return (notebookPrice * notebookQuantity) + (pencilPrice * pencilQuantity);
        }

    }
}
