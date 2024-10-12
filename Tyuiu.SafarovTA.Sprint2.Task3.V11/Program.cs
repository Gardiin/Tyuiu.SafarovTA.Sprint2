using Tyuiu.SafarovTA.Sprint2.Task3.V11.Lib;
namespace Tyuiu.SafarovTA.Sprint2.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #3                                                                     *");
            Console.WriteLine("* Вариант #11                                                                    *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с           *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит значение    *");
            Console.WriteLine("* переменной X с клавиатуры. Округлить полученное значение до трех знаков        *");
            Console.WriteLine("* после запятой;                                                                 *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Введите X:                                                                     *");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}
