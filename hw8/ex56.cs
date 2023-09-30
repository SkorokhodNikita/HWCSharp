// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int SetNumber(string message)
{
    Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns, int minElem = 0, int maxElem = 9)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minElem, maxElem + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"\t{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int SumArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] += matrix[i, j];
        }
        System.Console.WriteLine($"Sum row {i + 1} = {array[i]}");
    }
    int minSum = array[0];
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (array[i] < minSum)
        {
            array[i] = minSum;
            minRow = i + 1;
        }
    }
    return minRow;
}

int rows = SetNumber("rows");
int columns = SetNumber("columns)");
System.Console.WriteLine();

if (rows <= columns) System.Console.WriteLine("rows <= columns");
else
{
    int[,] matrix = GetMatrix(rows, columns);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    int row = SumArray(matrix);
    System.Console.WriteLine();
    Console.WriteLine($"Min sum in {row} row.");
}
