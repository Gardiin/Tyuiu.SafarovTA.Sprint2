using Tyuiu.SafarovTA.Sprint2.Task3.V11.Lib;
namespace Tyuiu.SafarovTA.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            double x = 2;
            DataService ds = new DataService();
            Assert.AreEqual(2.585, ds.Calculate(x));
        }
    }
}