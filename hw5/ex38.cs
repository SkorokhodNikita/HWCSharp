// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int GetNumber(string message)
{
    Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[] GetArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 100, 2);
    }
    return array;
}

void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i]; 
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i]; 
    }
    return min;
}

double[] array = GetArray(GetNumber("(size): "));
Print(array);
Console.WriteLine($"max = {Max(array)} min = {Min(array)}");
Console.WriteLine($"Разница между максимальным и минимальным значениями элементов массива = {Math.Round(Max(array) - Min(array), 2)}");
