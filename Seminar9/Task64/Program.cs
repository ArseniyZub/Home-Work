// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void IntervalNum(int num)
{
    if(num <= 0) return;
    if (num >= 1)
    {
        Console.Write(num + ",");
        IntervalNum(num - 1);
    }
}

int num = int.Parse(Console.ReadLine()!);
IntervalNum(num);
