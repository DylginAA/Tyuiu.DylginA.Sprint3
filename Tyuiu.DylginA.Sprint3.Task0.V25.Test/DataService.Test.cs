using Newtonsoft.Json.Linq;
using Tyuiu.DylginA.Sprint3.Task0.V25.Lib;

namespace Tyuiu.DylginA.Sprint3.Task0.V25.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 14;
            double wait = ds.GetSumSeries(value,startValue,stopValue);
            double result  = 0.69;
            Assert.AreEqual(result, wait);  
        }
    }
}