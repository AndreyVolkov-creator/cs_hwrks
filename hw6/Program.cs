#region 1

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 5
// 1, -7, 567, 89, 223-> 3 

// Console.WriteLine("Сколько чисел вы хотите ввести?");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine($"Вы ввели {PositiveNums(array)} чисел больше 0");




// int PositiveNums(int[] array)
// {
//     int result = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) result++;
//     }

//     return result;
// }

// void FillArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"Введите {i+1} число");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }  
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

#endregion

#region 2

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y1 = k1 * x + b1, y2 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
double[] result = CrossPoint(b1, k1, b2, k2);
Console.WriteLine($"Пересечение в точке: ({result[0]} ; {result[1]})");




double[] CrossPoint(double b1,double k1,double b2,double k2)
{
    double[] array = new double[2];
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;
    x = Math.Round(x, 3);
    array[0] = x;
    y = Math.Round(y, 3);
    array[1] = y;
    return array;
}

#endregion