//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GetArrray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите количество чисел M: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArrray(size);

int result = Count(array);
Console.WriteLine($"{String.Join(", ", array)} -> {result}");