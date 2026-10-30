
using Tyuiu.Krylovvs.Sprint3.Task4.V20.Lib;

namespace Tyuiu.Krylovvs.Sprint3.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService DataService = new DataService();

            double Expected = 1.0 / (Math.Cos(1) - 1) + 2.5;
            double Actual = DataService.Calculate(0, 1);

            Assert.AreEqual(Expected, Actual, 1e-10);
        }
    }
}
