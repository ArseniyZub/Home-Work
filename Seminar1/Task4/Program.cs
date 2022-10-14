//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите три числа: ");

int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
int number3 = int.Parse(Console.ReadLine()!);

if (number1 > number2 && number1 > number3)
{
Console.WriteLine($"Число {number1} самое большое");
}
else if (number2 > number1 && number2 > number3)
{
Console.WriteLine($"Число {number2} самое большое");
}
else if (number3 > number1 && number3 > number2)
{
Console.WriteLine($"Число {number3} самое большое");
}
else
{
Console.WriteLine($"Все числа равны");
}
