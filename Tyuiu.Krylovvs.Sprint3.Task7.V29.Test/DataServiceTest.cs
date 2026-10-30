
using Tyuiu.Krylovvs.Sprint3.Task7.V29.Lib;

namespace Tyuiu.Krylovvs.Sprint3.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService DataService = new DataService();

            double[] Expected = { -9.00 };
            double[] Actual = DataService.GetMassFunction(0, 0);

            CollectionAssert.AreEqual(Expected, Actual);
        }
    }
}
