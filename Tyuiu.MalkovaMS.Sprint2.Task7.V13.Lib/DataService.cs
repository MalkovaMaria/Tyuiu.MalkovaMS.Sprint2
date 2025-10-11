using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MalkovaMS.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((x > 0) && (x < 1) && (x * x + y * y <= 1)) || ((y <= 1) && (y >= -1) && (x > 0) && (y - x > -1)))
                res = true;
            else
                res = false;
            return res;
        }
    }
}
