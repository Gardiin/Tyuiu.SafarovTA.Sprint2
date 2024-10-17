using Tyuiu.SafarovTA.Sprint2.Task7.V3.Lib;
namespace Tyuiu.SafarovTA.Sprint2.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #7                                                                     *");
            Console.WriteLine("* Вариант #3                                                                     *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные    *");
            Console.WriteLine("* значения) и вычисляет, находится ли точка с координатами X,Y в заштрихованной  *");
            Console.WriteLine("* области.                                                                       *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Введите X:                                                                     *");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите Y:                                                                     *");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));

            Console.ReadLine();
        }
    }
}
