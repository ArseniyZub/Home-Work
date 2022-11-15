// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void GetIntersection()
{
    Console.WriteLine($"Введите координаты: ");
    double b1 = int.Parse(Console.ReadLine()!);
    double k1 = int.Parse(Console.ReadLine()!);
    double b2 = int.Parse(Console.ReadLine()!);
    double k2 = int.Parse(Console.ReadLine()!);

    if(k1 == k2 && b1 + b2 == 0)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
    double x = Math.Round((b2 - b1)/(k1 - k2), 1);
    double y = Math.Round((k1*x + b1), 1);
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
    }
}

GetIntersection();