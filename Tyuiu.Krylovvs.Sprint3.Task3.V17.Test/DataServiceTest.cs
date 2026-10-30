
using Tyuiu.Krylovvs.Sprint3.Task3.V17.Lib;

namespace Tyuiu.Krylovvs.Sprint3.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService DataService = new DataService();

            int Expected = 98;
            int Actual = DataService.ConvertStringToInt("*vn98n! b,");

            Assert.AreEqual(Expected, Actual);
        }
    }
}
