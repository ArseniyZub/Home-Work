//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumNumers(int value)
{
    int sum = 0;
    int i = 0;
    while(value != 0)
    {
        i = value%10;
        sum += i;
        value /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int result = GetSumNumers(N);
Console.WriteLine($"Сумма цифр числа {N} = {result}");