// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

int GetNumber(string message)
{
    Console.Write($"Введите четверть {message} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void Show(int x)
{
    if (x == 1)
    {
        System.Console.WriteLine("От +X до бесконечности, От +Y до бесконечности");
    }
    else if (x == 2)
    {
        System.Console.WriteLine("От -X до бесконечности, От +Y до бесконечности");
    }
    else if (x == 3)
    {
        System.Console.WriteLine("От -X до бесконечности, От -Y до бесконечности");
    }
    else if (x == 4)
    {
        System.Console.WriteLine("От +X до бесконечности, От -Y до бесконечности");
    }
    else
    {
        Console.WriteLine("Вы ввели не номер четверти");
    }
}

int numX = GetNumber("");
Show(numX);

// int quarter = GetNumber("quarter");
// const int num2 = 1 ;

// switch (quarter)
// {
//     case num2:
//         {
//             Console.WriteLine("x>0 y>0");
//             break;
//         }
//     case 2:
//         {
//             Console.WriteLine("x<0 y>0");
//             break;
//         }
//     case 3:
//         {
//             Console.WriteLine("x<0 y<0");
//             break;
//         }
//     case 4:
//         {
//             Console.WriteLine("x>0 y<0");
//             break;
//         }

//     default:
//         {
//             Console.WriteLine("Введена неправильная четверть");
//             break;
//         }
// }