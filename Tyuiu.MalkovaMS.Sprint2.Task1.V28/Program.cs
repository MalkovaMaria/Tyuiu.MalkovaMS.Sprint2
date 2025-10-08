using Tyuiu.MalkovaMS.Sprint2.Task1.V28.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 247;
        int b = 654;
        int c = 671;
        int d = 671;
        bool[] res = ds.GetLogicOperations(a, b, c, d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
        Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,последовательность *");
        Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,       *");
        Console.WriteLine("* которая вернёт логическую последовательность (массив):                  *");
        Console.WriteLine("* (True, False, True, False, True, False), при a = 247, b = 654, c = 671, *");
        Console.WriteLine("* d = 671                                                                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}