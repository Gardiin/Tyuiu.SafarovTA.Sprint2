using Tyuiu.SafarovTA.Sprint2.Task0.V11.Lib;
namespace Tyuiu.SafarovTA.Sprint2.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            int x = 8105, y = 275;
            DataService ds = new DataService();
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool [] wait = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}