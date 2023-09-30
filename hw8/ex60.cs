// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int SetNumber(string message)
{
    Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,,] GetMatrix(int rows, int columns, int rocol, int minElem = 10, int maxElem = 99)
{
    int[,,] matrix = new int[rows, columns, rocol];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < rocol; k++)
            {
                int element = rand.Next(minElem, maxElem + 1);
                if (FindElement(matrix, element)) continue;        // К сожалению так и не понял как сделать так чтобы,
                matrix[i, j, k] = element;                         // если элемент повторяется, он заменялся на другой, которого нет.
            }
        }
    }
    return matrix;
}

bool FindElement(int[,,] matrix, int element)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == element) return true;
            }
        }
    }
    return false;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}

int rows = SetNumber("rows");
int columns = SetNumber("columns");
int rocol = SetNumber("rocol");
System.Console.WriteLine();
int[,,] matrix = GetMatrix(rows, columns, rocol);
PrintMatrix(matrix);
