// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int SetNumber(string message)
{
    Console.Write($"Enter number {message}: ");
    string strNum = Console.ReadLine();

    if (int.TryParse(strNum, out int num))
    {
        return num;
    }

    Console.Clear();
    Console.WriteLine("Incorrect data!");
    return SetNumber(message);
}

int NumToOne(int num, int count)
{
    if (num == 1)
    {
        return num;
    }
    else 
    {
        Console.Write($"{num} ");
        return NumToOne(num - 1, count);
    }
}

int numN = SetNumber("N (>0)");
if (numN>0)
{
    System.Console.WriteLine(NumToOne(numN, 1));
}
else
{
    System.Console.WriteLine("N must be > 0 !"); 
}
