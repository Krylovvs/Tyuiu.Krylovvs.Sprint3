
using Tyuiu.Krylovvs.Sprint3.Task5.V24.Lib;

namespace Tyuiu.Krylovvs.Sprint3.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService DataService = new DataService();

            double Expected = 3 * (
                (Math.Pow(2, 1) + 2) * Math.Sin(1) +
                (Math.Pow(2, 2) + 2) * Math.Sin(2) +
                (Math.Pow(2, 3) + 2) * Math.Sin(3) +
                (Math.Pow(2, 4) + 2) * Math.Sin(4) +
                (Math.Pow(2, 5) + 2) * Math.Sin(5) +
                (Math.Pow(2, 6) + 2) * Math.Sin(6) +
                (Math.Pow(2, 7) + 2) * Math.Sin(7) +
                (Math.Pow(2, 8) + 2) * Math.Sin(8) +
                (Math.Pow(2, 9) + 2) * Math.Sin(9) +
                (Math.Pow(2, 10) + 2) * Math.Sin(10) +
                (Math.Pow(2, 11) + 2) * Math.Sin(11) +
                (Math.Pow(2, 12) + 2) * Math.Sin(12));

            double Actual = DataService.GetSumSumSeries(2, 1, 1, 3, 12);

            Assert.AreEqual(Expected, Actual, 1e-10);
        }
    }
}
