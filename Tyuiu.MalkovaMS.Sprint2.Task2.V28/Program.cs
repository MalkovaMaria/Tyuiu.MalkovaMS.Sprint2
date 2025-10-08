using Tyuiu.MalkovaMS.Sprint2.Task2.V28.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x, y;
        Console.Title = "Спринт #2 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if - полная и краткая формы записи                       *");

        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
        Console.WriteLine("* вычисляет, находится ли точка с координатами Х,У в заштрихованной обл.  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение Х:");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение У:");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool res = ds.CheckDotInShadedArea(x, y);
        if (res == true)
            Console.WriteLine("Точка находится в заштрихованной области");
        else
            Console.WriteLine("Точка не находится в заштрихованной области");
        Console.ReadKey();    

    }

}