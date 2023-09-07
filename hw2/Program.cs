// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if (num < 100 || num > 999)
{
    System.Console.WriteLine("Некорректное число");
}
else
{
    int num1 = (num % 100) / 10;
    System.Console.WriteLine(num1);
}


