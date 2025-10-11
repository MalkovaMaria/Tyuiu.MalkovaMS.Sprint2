using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MalkovaMS.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string month = Convert.ToString(m);
            string day = Convert.ToString(n);
            string res;
            if (n < 1 | m > 12 | n > 31 | m < 1 | (m == 1 & n == 1))
            {
                res = "0";
            }
            else
            {
                switch (m, n)
                {
                    case (2, 1):
                        res = "31.01";
                        break;
                    case (3, 1):
                        res = "28.02";
                        break;
                    case (4, 1):
                        res = "31.03";
                        break;
                    case (5, 1):
                        res = "30.04";
                        break;
                    case (6, 1):
                        res = "31.05";
                        break;
                    case (7, 1):
                        res = "30.06";
                        break;
                    case (8, 1):
                        res = "31.07";
                        break;
                    case (9, 1):
                        res = "31.08";
                        break;
                    case (10, 1):
                        res = "30.09";
                        break;
                    case (11, 1):
                        res = "31.10";
                        break;
                    case (12, 1):
                        res = "30.11";
                        break;

                    default:
                        if ((n - 1) > 0 & (n - 1) < 10)
                            day = "0" + Convert.ToString(n-1);
                        if (m > 0 & m < 10)
                            month = "0" + month;
                        res = day + "." + month;

                                
                        break;

                }
            }
            return res;
        }
    }
}
