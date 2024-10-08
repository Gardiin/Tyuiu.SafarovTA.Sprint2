using Tyuiu.SafarovTA.Sprint2.Task0.V11.Lib;
namespace Tyuiu.SafarovTA.Sprint2.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] res = new bool[6];
            int x = 8105, y = 275;
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #0                                                                     *");
            Console.WriteLine("* Вариант #11                                                                    *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических выражений,  *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                          *");
            Console.WriteLine("* (True, False, True, False, True, False), при x = 8105, y = 275                 *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* x = 8105, y = 275                                                              *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            res = ds.GetCompareOperations(x, y);

            for (int i = 0; i < res.Length; i++) 
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}
