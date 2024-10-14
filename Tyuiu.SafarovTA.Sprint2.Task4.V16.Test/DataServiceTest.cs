using Tyuiu.SafarovTA.Sprint2.Task4.V16.Lib;
namespace Tyuiu.SafarovTA.Sprint2.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            double x = 2, y = 3;
            DataService ds = new DataService();
            Assert.AreEqual(1.235, ds.Calculate(x, y));
        }
    }
}