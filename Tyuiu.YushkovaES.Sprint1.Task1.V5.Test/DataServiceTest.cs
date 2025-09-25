using Tyuiu.YushkovaES.Sprint1.Task1.V5.Lib;
namespace Tyuiu.YushkovaES.Sprint1.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
