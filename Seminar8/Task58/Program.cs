// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillMatrix(int row, int col, int minValue, int maxValue)
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
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{String.Join(',', matrix[i, j])} ");
        }
        Console.WriteLine();
    }
}

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] maxrixDiv = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < maxrixDiv.GetLength(0); i++)
    {
        for (int j = 0; j < maxrixDiv.GetLength(1); j++)
        {
            maxrixDiv[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                maxrixDiv[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return maxrixDiv;
}

int[,] matrix1 = FillMatrix(2, 2, 1, 9);
int[,] matrix2 = FillMatrix(2, 2, 1, 9);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(DivMatrix(matrix1, matrix2));