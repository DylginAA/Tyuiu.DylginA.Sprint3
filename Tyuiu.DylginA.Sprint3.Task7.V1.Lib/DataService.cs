﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DylginA.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] MassResult = new double[11];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double result;
                if (x + 1.2 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = Math.Round((Math.Sin(x) / (x + 1.2) + Math.Cos(x) * 7 * x - 2), 2);
                }
                MassResult[index] = result;
                Console.WriteLine($"F({x}) = {result}");
                index++;
            }
            return MassResult;
        }
    }
}
