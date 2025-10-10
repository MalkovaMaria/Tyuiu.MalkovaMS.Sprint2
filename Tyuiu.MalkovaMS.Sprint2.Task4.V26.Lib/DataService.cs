using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MalkovaMS.Sprint2.Task4.V26.Lib
{
    public class DataService : ISprint2Task4V26
    {
        public double Calculate(double x, double y)
        {
            double res = x - 2 < y / 2 ? Math.Pow((10 + (2 / (x * x))), y) : x * x - (1 / y);
            return Math.Round(res, 3);
        }
    }
}
