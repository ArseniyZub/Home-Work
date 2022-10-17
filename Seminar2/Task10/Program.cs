Console.Write("Введите трехзначное число: ");
int value = int.Parse(Console.ReadLine()!);

int result = value%100/10;
Console.WriteLine($"{value} -> {result}");
