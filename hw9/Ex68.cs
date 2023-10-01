// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int numM = SetNumber("M");
int numN = SetNumber("N");
if (numM > 0 && numN > 0)
{
    Console.WriteLine($"Функция Аккермана A({numM}, {numN}) = {Akkerman(numM, numN)}");
}
else
{
    System.Console.WriteLine("N, M must be > 0");
}
