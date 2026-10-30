
using Tyuiu.Krylovvs.Sprint3.Task0.V13.Lib;

namespace Tyuiu.Krylovvs.Sprint3.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();

            double Expected = 0.5403023058681398;
            double Actual = ds.GetSumSeries(0.5, 1, 1);

            Assert.AreEqual(Expected, Actual, 1e-10);
        }
    }
}
