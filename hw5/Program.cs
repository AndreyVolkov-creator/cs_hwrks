#region 1

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] array = new int[4];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine($"Кол-во четных эллементов массива равно {NumP(array)}");




// void FillArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// int NumP(int[] array)
// {
//     int result = 0;
//     foreach (int item in array)
//     {
//         if(item % 2 == 0) result++;
//     }
//     return result;
// }
    
#endregion

#region 2

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[4];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine($"Сумма элементов на нечетных позициях равна {Summ(array)}");




// void FillArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 21);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// int Summ(int[] array)
// {
//     int result = 0;

//     for(int i = 1; i < array.Length; i += 2)
//         result += array[i];

//     return result;
// }
    
#endregion

#region 3

//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];
FillArray(array);
PrintArray(array);
double[] res = Differ(array);
Console.WriteLine($"Разница между макс и мин значением элементов массива равна {res[0]} - {res[1]} = {res[2]}");




void FillArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = RandomDouble(0, 100);
}

void PrintArray(double[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

double[] Differ(double[] array)
{
    double result = 0;
    double max = 0;
    double min = 100;

    foreach (int item in array)
    {
        if(max < item) max = item;
    }
    foreach (int item in array)
    {
        if(min > item) min = item;
    }

    result = max - min;
    double[] newArray = {max, min, result};

    return newArray;
}

double RandomDouble(double minValue, double maxValue)
{
    Random random = new Random();

	return minValue + (maxValue - minValue) * random.NextDouble();
}

#endregion