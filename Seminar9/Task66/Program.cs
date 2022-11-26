// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int firstNum, int secondNum)
{
    if(firstNum == secondNum) return firstNum;

    if (firstNum < secondNum) 
    {
        return secondNum + SumNumbers(firstNum, secondNum - 1);
    }
    else return secondNum + SumNumbers(firstNum, secondNum + 1); 
}

int firstNum = int.Parse(Console.ReadLine()!);
int secondNum = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumbers(firstNum, secondNum));