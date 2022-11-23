// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindMinSum(int[,] array)
{
    int minSum = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        
        if(minSum == 0) minSum = sum;

        if (sum < minSum)
        {
            minSum = sum;
            index++;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {index + 1}, сумма элементов -> {minSum}");
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

int[,] array = FillArray(3, 4, 1, 9);
PrintArray(array);
FindMinSum(array);