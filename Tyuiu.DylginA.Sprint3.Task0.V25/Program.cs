using Tyuiu.DylginA.Sprint3.Task0.V25.Lib;

namespace Tyuiu.DylginA.Sprint3.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            int startValue = 1;
            int stopValue = 14;
            DataService ds = new DataService();
            Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}
