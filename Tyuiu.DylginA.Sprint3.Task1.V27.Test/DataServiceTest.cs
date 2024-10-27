using Tyuiu.DylginA.Sprint3.Task1.V27.Lib;
namespace Tyuiu.DylginA.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startValue = 1;
            int stopValue = 5;
            double wait = ds.GetMultiplySeries(value, startValue, stopValue);
            double res = 1;
            Assert.AreEqual(res, wait);
        }
    }
}