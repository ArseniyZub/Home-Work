// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillArray(double minValue, double maxValue)
{
    int m = int.Parse(Console.ReadLine()!);
    int n = int.Parse(Console.ReadLine()!);
    double[,] array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double random = new Random().NextDouble();
            array[i, j] = Math.Round(minValue + (maxValue - minValue) * random, 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(FillArray(-9, 9));


