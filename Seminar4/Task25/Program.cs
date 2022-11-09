//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetDegree(int value, int degree)
{
    int product = 1;
    for(int i = 1; i <= degree; i++)
    {
        product *= value;
    }
    return product;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int n = int.Parse(Console.ReadLine()!);

int result = GetDegree(number, n);
Console.WriteLine($"{number}, {n} -> {result}");