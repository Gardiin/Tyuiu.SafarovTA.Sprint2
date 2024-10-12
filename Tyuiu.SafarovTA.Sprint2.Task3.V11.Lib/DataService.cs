using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SafarovTA.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            if (x > 0)
            {
                return Math.Round((x + Math.Pow((x - 15) / (x - 19), x)), 3);
            }
            else if (x == 0)
            {
                return Math.Round((Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12), 3);
            }
            else if ((x > 0) && (x > -15))
            {
                return Math.Round(Math.Pow((1 + 1 / Math.Pow(x, 2)), x), 3);
            }
            else
            {
                return Math.Round((x + 10 * x - (1 / x)), 3);
            }
        }
    }
}
