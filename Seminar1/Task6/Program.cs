//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

Console.WriteLine("Введите чило: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0) 
{
    Console.WriteLine($"Чило {number} является четным");
}
else
{
    Console.WriteLine($"Чило {number} не является четным");
}

