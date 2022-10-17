//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int value = int.Parse(Console.ReadLine()!);

int result = value%100/10;
Console.WriteLine($"{value} -> {result}");
