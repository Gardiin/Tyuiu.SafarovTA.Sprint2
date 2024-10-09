using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SafarovTA.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //==, !=, <, >, <=, >=
            //|, &, ||, &&, !, ^
            //false, false, true, false, true, false

            //a = 915, b = 169, c = 174, d = 133 
            bool[] res = new bool[6];

            res[0] = a == b | c == d;
            res[1] = a < b & c < d;
            res[2] = a >= b || c >=  d;
            res[3] = a <= b && c <= d;
            res[4] = a != b | c != d;
            res[5] = a < b && c < d;

            return res;
        }
    }
}
