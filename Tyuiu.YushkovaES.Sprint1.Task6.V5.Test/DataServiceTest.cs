using Tyuiu.YushkovaES.Sprint1.Task6.V5.Lib;
namespace Tyuiu.YushkovaES.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string input = "казак анна доход";
            string wait = "казак, анна, доход";
            string result = ds.CheckSymmetricalWords(input);

            Assert.AreEqual(wait, result);

        }
    }
}
