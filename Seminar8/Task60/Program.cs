// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillArray(int row, int col, int dep, int minValue, int maxValue)
{
    int[,,] array = new int[row, col, dep];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = CheckOrigArray(array, i, j, k, minValue, maxValue);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
        }
    }
}

int CheckOrigArray(int[,,] array, int i, int j, int k, int minValue, int maxValue)
{
    int value = new Random().Next(minValue, maxValue + 1);
    bool orig = true;
    while (orig)
    {
        bool exit = false;
        for (int i1 = 0; i1 < array.GetLength(0); i1++)
        {
            if(exit) break;
            for (int j1 = 0; j1 < array.GetLength(1); j1++)
            {
                for (int k1 = 0; k1 < array.GetLength(2); k1++)
                {
                    if(array[i1, j1, k1] == value) 
                    {
                        exit = true; 
                        break; 
                    }
                    if(i1 == i && j1 == j && k1 == k) orig = false;
                }
            }
        }
    }
    return value;
}
int[,,] array = FillArray(2, 2, 2, 10, 99);
PrintArray(array);