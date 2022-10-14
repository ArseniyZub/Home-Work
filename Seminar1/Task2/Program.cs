//Задача2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

Console.WriteLine("Введите два числа: ");


int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
Console.WriteLine($"Число {number1} больше числа {number2}");
}
else if (number1 < number2)
{
Console.WriteLine($"Число {number2} больше числа {number1}");
}
else
{
Console.WriteLine($"Число {number1} равно числу {number2}");
} 