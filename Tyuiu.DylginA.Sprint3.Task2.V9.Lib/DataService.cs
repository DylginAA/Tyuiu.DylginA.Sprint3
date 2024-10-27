using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DylginA.Sprint3.Task2.V9.Lib
{
    public class DataService : ISprint3Task2V9
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double result = 0;
            do {
                result += Math.Pow((1 / Math.Pow(value, startValue)), 2);
                startValue++;
            } while(startValue<=stopValue);
            return Math.Round(result,3);
        }
    }
}
