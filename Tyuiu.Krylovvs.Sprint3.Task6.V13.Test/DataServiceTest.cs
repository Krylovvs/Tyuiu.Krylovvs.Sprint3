
using Tyuiu.Krylovvs.Sprint3.Task6.V13.Lib;

namespace Tyuiu.Krylovvs.Sprint3.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService DataService = new DataService();

            int Expected = 117;
            int Actual = DataService.GetSumTheDivisors(8, 17);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
