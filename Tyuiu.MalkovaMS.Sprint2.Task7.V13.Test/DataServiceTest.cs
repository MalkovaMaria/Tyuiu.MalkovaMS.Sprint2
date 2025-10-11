using Tyuiu.MalkovaMS.Sprint2.Task7.V13.Lib;

namespace Tyuiu.MalkovaMS.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.2;
            double y = -0.5;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
