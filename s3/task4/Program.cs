// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


System.Console.Write("Введите число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

int index = 1;

while (index <= num)
{
    System.Console.Write(index*index);
    System.Console.Write(" ");
    index++;
}