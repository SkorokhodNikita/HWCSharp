// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int GetNumber(string message)
{
    Console.Write($"Введите координату {message} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numX1 = GetNumber("X1");
int numY1 = GetNumber("Y1");
int numX2 = GetNumber("X2");
int numY2 = GetNumber("Y2");

double numX = Math.Pow((numX2 - numX1), 2);
double numY = Math.Pow((numY2 - numY1), 2);

double result = Math.Sqrt(numX + numY);

System.Console.WriteLine($"Расстояние = {Math.Round(result, 2)}");