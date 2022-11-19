// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int row, int col, int minValue, int maxValue)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{String.Join(',', array[i, j])} ");
        }
        Console.WriteLine();
    }
}

void ArithMean(int[,] array)
{
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
        }
        result = Math.Round(result/array.GetLength(0), 1);
        Console.Write($"{result}; ");
        result = 0;
    }
}

int[,] array = FillArray(3, 4, 1, 9);
PrintArray(array);
ArithMean(array);