using Tyuiu.SafarovTA.Sprint2.Task5.V8.Lib;
namespace Tyuiu.SafarovTA.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            int m = 4;
            int n = 1;
            DataService ds = new DataService();
            Assert.AreEqual("31.03", ds.FindDateOfPreviousDay(m, n));
        }
    }
}