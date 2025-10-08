using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MalkovaMS.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = new bool();
            if ((x == 2 && y <= 5 && y >= 4) || (x >= 3 && x <= 5 && y >= 3 && y <= 7) ||
                    (x >= 6 && x <= 8 && y >= 5 && y <= 7) || (x >= 9 && x <= 12 && y == 5) ||
                    (x >= 10 && x <= 12 && y >= 2 && y <= 4) || (x >= 6 && x <= 8 && y >= 8 && y <= 10) ||
                    (x >= 3 && x <= 12 && y == 11) || (x >= 7 && x <= 10 && y == 12) ||
                    (x == 13 && y >= 9 && y <= 13) || (x == 13 && y >= 2 && y <= 3))
                res = true;
            else 
                res = false;
            return res;
        }
    }
}
