﻿using Tyuiu.DylginA.Sprint3.Task2.V9.Lib;
namespace Tyuiu.DylginA.Sprint3.Task2.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3");
            Console.WriteLine("* Тема: Оператор цикла for");
            Console.WriteLine("* Задание #2");
            Console.WriteLine("* Вариант #9");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Написать программу используя цикл for, которая вычисляет сумму ряда по формуле, при X=5");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Начальное значение = 1");
            Console.WriteLine("Конечное значение = 10");
            Console.WriteLine("Х = 5");
            int value = 5;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}