using Tyuiu.MalkovaMS.Sprint2.Task6.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int g, m, n;
        Console.Title = "Спринт #2 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");

        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
        Console.WriteLine("* использованием оператора switch                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите год (високосный):");
        g = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номер месяца:");
        m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число:");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string resultat = ds.FindDateOfPreviousDay(g, m, n);
        Console.WriteLine("Дата предыдущего дня: " + resultat);

        Console.ReadKey();
    }
}