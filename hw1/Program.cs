// 1
// Console.Write("Enter first number: ");
// string StrNumA = Console.ReadLine();
// int numA = int.Parse(StrNumA);

// Console.Write("Enter second number: ");
// string StrNumB = Console.ReadLine();
// int numB = int.Parse(StrNumB);

// if(numA>=numB)
// {
//     Console.Write("Max: ");
//     Console.WriteLine(numA);
// }
// else
// {
//     Console.Write("Max: ");
//     Console.WriteLine(numB); 
// }


// 2
// Console.Write("Enter first number: ");
// string strNumA = Console.ReadLine();
// int numA = int.Parse(strNumA);

// Console.Write("Enter second number: ");
// string strNumB = Console.ReadLine();
// int numB = int.Parse(strNumB);

// Console.Write("Enter third number: ");
// string strNumC = Console.ReadLine();
// int numC = int.Parse(strNumC);

// int max = numA;

// if(numB>=max) max = numB;
// if(numC>=max) max = numC;

// Console.Write("Max = ");
// Console.WriteLine(max);


// 3
// Console.Write("Enter number: ");
// string strNum = Console.ReadLine();
// int num = int.Parse(strNum);

// if(num % 2 == 0) {
//     Console.WriteLine("Четное");
// }
// else{
//     Console.WriteLine("Нечетное");
// }

// 4
Console.Write("Enter number: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int i = 0;

while (i < num-1)
{
    i+=2;
    Console.Write(i);
    Console.Write(" ");
}