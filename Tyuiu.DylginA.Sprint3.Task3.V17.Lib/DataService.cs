﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DylginA.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            string result = "";
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }
            return Convert.ToInt32(result);
        }
    }
}
