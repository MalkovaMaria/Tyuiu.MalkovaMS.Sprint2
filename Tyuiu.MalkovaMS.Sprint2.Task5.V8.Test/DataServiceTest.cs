using Tyuiu.MalkovaMS.Sprint2.Task5.V8.Lib;

namespace Tyuiu.MalkovaMS.Sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual($"31.01", ds.FindDateOfPreviousDay(2, 1));
            Assert.AreEqual($"28.02", ds.FindDateOfPreviousDay(3, 1));
            Assert.AreEqual($"31.03", ds.FindDateOfPreviousDay(4, 1));
            Assert.AreEqual($"30.04", ds.FindDateOfPreviousDay(5, 1));
            Assert.AreEqual($"31.05", ds.FindDateOfPreviousDay(6, 1));
            Assert.AreEqual($"30.06", ds.FindDateOfPreviousDay(7, 1));
            Assert.AreEqual($"31.07", ds.FindDateOfPreviousDay(8, 1));
            Assert.AreEqual($"31.08", ds.FindDateOfPreviousDay(9, 1));
            Assert.AreEqual($"30.09", ds.FindDateOfPreviousDay(10, 1));
            Assert.AreEqual($"31.10", ds.FindDateOfPreviousDay(11, 1));
            Assert.AreEqual($"30.11", ds.FindDateOfPreviousDay(12, 1));
        }
    }
}
