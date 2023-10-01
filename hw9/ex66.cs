// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int SumElements(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return SumElements(m + 1, n) + m;
    }
}

int numM = SetNumber("M");
int numN = SetNumber("N");
if (numM > 0 && numN>0 && numN >= numM)
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {SumElements(numM, numN)}");
}
else
{
    System.Console.WriteLine("N, M must be > 0 and N must be > M");
}
