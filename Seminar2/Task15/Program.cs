﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int value = int.Parse(Console.ReadLine()!);

if (value == 6 || value == 7) 
{
    Console.WriteLine($"Цифра {value} является выходным днем");
}
else 
{
    Console.WriteLine($"Цифра {value} не является выходным днем");
}