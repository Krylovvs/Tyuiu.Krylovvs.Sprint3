
using Tyuiu.Krylovvs.Sprint3.Task0.V13.Lib;

namespace Tyuiu.Krylovvs.Sprint3.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService dataService = new DataService();

            double expected = 1.9950041652780257;
            double actual = dataService.GetMultiplySeries(1, 1);

            Assert.AreEqual(expected, actual, 1e-10);
        }
    }
}
