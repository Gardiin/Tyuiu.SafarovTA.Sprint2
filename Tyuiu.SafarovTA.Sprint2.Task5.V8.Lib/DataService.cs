using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SafarovTA.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (n < 1 | m > 12 | n > 31 | m < 1 | (m == 1 & n == 1))
            {
                return "0";
            }
            if (n > 1)
            {
                return Convert.ToString(n - 1) + "." + Convert.ToString(m);
            }
            switch(m)
            {
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    return "31." + Convert.ToString(m);
                case 5:
                case 7:
                case 10:
                case 12:
                    return "30." + Convert.ToString(m);
                case 3:
                    return "28.2";
                default:
                    return "0";
            }
        }
    }
}
