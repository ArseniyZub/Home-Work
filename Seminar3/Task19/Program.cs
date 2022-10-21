//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int value = int.Parse(Console.ReadLine()!);

String GetPall(int value)
{
    int one = value/10000;
    int two = value/1000%10;
    int four = value%100/10;
    int five = value%10;
    if (one == five && two == four)
    {
        return "да";
    }
    else
    {
        return "нет";
    }
}
Console.WriteLine($"{value} -> {GetPall(value)}");