using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MalkovaMS.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (g % 4 == 0)
                switch (n)
                {
                    case 1:
                        switch (m)
                        {
                            case 1:
                                return $"31.12.{g - 1}";
                            case 2:
                            case 4:
                            case 6:
                            case 8:
                            case 9:
                                return $"31.0{m - 1}.g";
                            case 11:
                                return $"31.{m - 1}.g";
                            case 3:
                                return $"29.02.{g}";
                            case 5:
                            case 7:
                                return $"30.{m - 1}.g";
                            case 10:
                            case 12:
                                return $"30.{m - 1}.g";
                            default:
                                return "Значение месяца должно быть от 1 до 12";
                        }
                    default:
                        switch (m)
                        {
                            case 2:
                                if (n < 0 || n > 29)
                                    return "Введите число от 1 до 29";
                                else
                                    return $"{n - 1}.{m}.{g}";
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                                if (n < 0 || n > 31)
                                    return "Введите число от 1 до 31";
                                else
                                    if (n < 11)
                                    return $"0{n - 1}.0{m}.{g}";
                                else
                                    return $"{n - 1}.0{m}.{g}";


                            case 10:
                            case 12:
                                if (n < 0 || n > 31)
                                    return "Введите число от 1 до 31";
                                else
                                    if (n < 11)
                                    return $"0{n - 1}.{m}.{g}";
                                else
                                    return $"{n - 1}.{m}.{g}";
                            case 4:
                            case 6:
                            case 9:
                                if (n < 0 || n > 30)
                                    return "Введите число от 1 до 30";
                                else
                                    if (n < 11)
                                    return $"0{n - 1}.0{m}.{g}";
                                else
                                    return $"{n - 1}.0{m}.{g}";
                            case 11:
                                if (n < 0 || n > 30)
                                    return "Введите число от 1 до 30";
                                else
                                    if (n < 11)
                                    return $"0{n - 1}.{m}.{g}";
                                else
                                    return $"{n - 1}.{m}.{g}";
                            default:
                                return "Значение месяца должно быть от 1 до 12";
                        }
                }
            else
                return "Введённый год не является високосныым";
        }
    }
}
