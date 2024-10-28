using Tyuiu.DylginA.Sprint3.Task3.V17.Lib;
namespace Tyuiu.DylginA.Sprint3.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3");
            Console.WriteLine("* Тема: Оператор цикла foreach");
            Console.WriteLine("* Задание #3");
            Console.WriteLine("* Вариант #17");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Используя цикл foreach удалить все буквы и знаки препинания, " +
                "оставить цифру затем преобразовать в число в строке: *vn98n! b,");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Строка:  *vn98n! b, ");
            string value = "*vn98n! b,";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.ConvertStringToInt(value));
        }
    }
}
