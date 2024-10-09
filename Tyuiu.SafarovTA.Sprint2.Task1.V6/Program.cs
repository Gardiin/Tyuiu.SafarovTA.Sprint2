using Tyuiu.SafarovTA.Sprint2.Task1.V6.Lib;
namespace Tyuiu.SafarovTA.Sprint2.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] res = new bool[6];
            int a = 915, b = 169, c = 174, d = 133;
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
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении) и   *");
            Console.WriteLine("* логических операций (|, &, ||, &&, !, ^, последовательность операций не должна *");
            Console.WriteLine("* нарушаться), а также арифметических выражений, которая вернет логическую       *");
            Console.WriteLine("* последовательность(массив): (False, False, True, False, True, False),          *");
            Console.WriteLine("* при a = 915, b = 169, c = 174, d = 133                                         *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* a = 915, b = 169, c = 174, d = 133                                             *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            res = ds.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}
