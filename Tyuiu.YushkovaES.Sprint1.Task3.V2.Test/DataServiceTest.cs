using Tyuiu.YushkovaES.Sprint1.Task3.V2.Lib;
namespace Tyuiu.YushkovaES.Sprint1.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double notebookPrice = 5;    // цена тетради
            int notebookQuantity = 4;    // количество тетрадей
            double pencilPrice = 5;      // цена карандаша
            int pencilQuantity = 6;      // количество карандашей
            double expected = 50;        // ожидаемый результат: (5*4) + (5*6) = 20 + 30 = 50

            var result = ds.PurchaseAmount(notebookPrice, notebookQuantity, pencilPrice, pencilQuantity);

            Assert.AreEqual(expected, result);

        }
    }
}
