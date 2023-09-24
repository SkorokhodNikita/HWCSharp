// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string message)
{
    Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Sum(int num)
{
    int count = 0;
    for (; num > 0; num /= 10)
    {
        count = count + num%10;
    }
    return count;
}

int result = Sum(GetNumber(""));
Console.WriteLine($"Сумма цифр в числе = {result}");
