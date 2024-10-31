using Tyuiu.DylginA.Sprint3.Task6.V3.Lib;
namespace Tyuiu.DylginA.Sprint3.Task6.V3
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
            Console.WriteLine("* Задание #6");
            Console.WriteLine("* Вариант #3");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:На отрезке, где x принимает значения от 13 до 19, вычислить сумму делителей больше 8");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Начальное значение диапозона = 13");
            Console.WriteLine("Конечное  значение диапазона= 19");
            int startValue = 13;
            int stopValue = 19;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));
        }
    }
}
