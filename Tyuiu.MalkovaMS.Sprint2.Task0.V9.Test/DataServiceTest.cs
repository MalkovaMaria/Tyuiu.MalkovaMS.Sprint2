using Tyuiu.MalkovaMS.Sprint2.Task0.V9.Lib;

namespace Tyuiu.MalkovaMS.Sprint2.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1054;
            int y = 375;
            bool[] wait = new bool[6] { true, true, true, true, true, false };
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
