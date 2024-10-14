using Tyuiu.SafarovTA.Sprint2.Task4.V16.Lib;
namespace Tyuiu.SafarovTA.Sprint2.Task4.V16
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
            Console.WriteLine("* Задание #4                                                                     *");
            Console.WriteLine("* Вариант #16                                                                    *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Твари скинули условия в виде картинки                                          *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                     *");
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
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
