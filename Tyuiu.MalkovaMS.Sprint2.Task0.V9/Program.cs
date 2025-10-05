using Tyuiu.MalkovaMS.Sprint2.Task0.V9.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 1054;
        int y = 375;

        Console.Title = "Спринт #2 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
        Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
        Console.WriteLine("* (True, True, True, True, True, False), при x = 1054, y = 375            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("X = " + x); 
        Console.WriteLine("Y = " + y);
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool[] res = ds.GetCompareOperations(x, y);
        for (int i=0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
        
    }
}