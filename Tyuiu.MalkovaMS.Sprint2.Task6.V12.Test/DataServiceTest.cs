using Tyuiu.MalkovaMS.Sprint2.Task6.V12.Lib;

namespace Tyuiu.MalkovaMS.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("31.12.2023", ds.FindDateOfPreviousDay(2024, 1, 1));
            Assert.AreEqual("03.11.2024", ds.FindDateOfPreviousDay(2024, 11, 4));
        }
    }
}
