//Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine()!);
int result = 0;
if (value/100 > 0)
{
    result = value%1000/100;
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}