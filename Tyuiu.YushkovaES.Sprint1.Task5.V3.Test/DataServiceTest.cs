using Tyuiu.YushkovaES.Sprint1.Task5.V3.Lib;
namespace Tyuiu.YushkovaES.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 12789;
            int wait = 7;
            int res = ds.Calculate(x);
            
            Assert.AreEqual(wait, res); 
        }
    }
}
