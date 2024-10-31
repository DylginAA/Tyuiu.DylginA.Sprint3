using Tyuiu.DylginA.Sprint3.Task5.V22.Lib;
namespace Tyuiu.DylginA.Sprint3.Task5.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах");
            Console.WriteLine("* Задание #5");
            Console.WriteLine("* Вариант #22");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=sin(x)/x");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Начальное значение1 = 1");
            Console.WriteLine("Конечное значение1 = 10");
            Console.WriteLine("Начальное значение2 = 1");
            Console.WriteLine("Конечное значение2 = 10");
            Console.WriteLine("Х = 5");
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        }
    }
}
