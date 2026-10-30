
using Tyuiu.Krylovvs.Sprint3.Task0.V13.Lib;

namespace Tyuiu.Krylovvs.Sprint3.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService DataService = new DataService();

            double Expected = 1.1883951057781212;
            double Actual = DataService.GetSumSeries(0, 1, 1);

            Assert.AreEqual(Expected, Actual, 1e-10);
        }
    }
}
