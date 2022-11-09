//Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

void GetTree(int value)
{
    for(int i = 1; i <= value; i++)
    {
        for(int j = 1; j <= 11 - i; j++)
        {
            Console.Write(" ");
        }
        for(int h = 1; h <= 2*i - 1; h++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");
    }
}

Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine()!);
GetTree(value);