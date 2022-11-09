//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetArray()
{
    int[] array = new int[8];
    for(int i = 0; i < 8; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

Console.Write("Введите числа: ");
Console.WriteLine(string.Join(",", GetArray()));









