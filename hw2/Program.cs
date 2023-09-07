// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

// Console.Write("Введите трехзначное число: ");
// string number = Console.ReadLine();
// int num = int.Parse(number);

// if (num < 100 || num > 999)
// {
//     System.Console.WriteLine("Некорректное число");
// }
// else
// {
//     int num1 = (num % 100) / 10;
//     System.Console.WriteLine(num1);
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if (num > 99)
{
    int num1;
    while (num > 999)
    {
        num = num / 10;
    }
    num1 = num % 10;
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}