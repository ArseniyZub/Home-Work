// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkerFunction(int firstNum, int secondNum)
{
    if (firstNum == 0)
    {
        return secondNum + 1;
    }
    else if ((firstNum > 0) && (secondNum == 0))
    {
        return AkkerFunction(firstNum - 1, 1);
    }
    else if ((firstNum > 0) && (secondNum > 0))
    {
        return AkkerFunction(firstNum - 1, AkkerFunction(firstNum, secondNum - 1));
    }
    else
    {
        return secondNum + 1;
    }
}

int firstNum = int.Parse(Console.ReadLine()!);
int secondNum = int.Parse(Console.ReadLine()!);
Console.WriteLine(AkkerFunction(firstNum, secondNum));