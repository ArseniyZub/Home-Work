// Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. 
// Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет.

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

void FindValue(int[,] array)
{
    int[] temp = new int[2];
    Console.Write("Введите число: ");
    int value = int.Parse(Console.ReadLine()!);

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == value)
            {
                Console.WriteLine($"Ваше число на позиции: [{i}, {j}]");
            }
        }
    }
    if(temp == null) 
    {
        Console.WriteLine("Такого числа нет в массиве");
    }
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

int[,] array = FillArray(4, 4, 1, 9);
FindValue(array);
PrintArray(array);

