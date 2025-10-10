using Tyuiu.MalkovaMS.Sprint2.Task4.V26.Lib;
namespace Tyuiu.MalkovaMS.Sprint2.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 110.25;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 99.5;
            Assert.AreEqual(wait, res);

        }
    }
}
