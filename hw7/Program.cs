#region 1

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите кол-во строк массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double [rows, columns];
// FillArray(array);
// PrintArray(array);




// double RandomDouble(double minValue, double maxValue)
// {
//     Random random = new Random();

// 	return minValue + (maxValue - minValue) * random.NextDouble();
// }

// void FillArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = Math.Round(RandomDouble(-10, 11),1);
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j], 4} \t");
//         Console.WriteLine();
//     }
// }

#endregion

#region 2

// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Массив будет заполнен числами от 0 до 9. Введите, какое число вы хотите найти?");
// int findNum = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int [5,5];
// FillArray(array);
// PrintArray(array);
// int[] userNumIndex = FindNumIndex(array, findNum);
// Console.WriteLine($"Ваше число находится на {userNumIndex[0]} строке, в {userNumIndex[1]} столбце");



// int[] FindNumIndex(int[,] array, int userValue)
// {
//     int rowResult = 0;
//     int colResult = 0;
    
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] == userValue)
//             {
//                 rowResult = i;
//                 colResult = j;
//                 goto Found;
//             }
//             else if (userValue > 9) Console.WriteLine("Вы ввели число, которого нет в массиве");

//         }
//     Found:       
//     int[] result = {rowResult+1, colResult+1};
//     return result;
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(0,10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j], 2} \t");
//         Console.WriteLine();
//     }
// }

#endregion

#region 3

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] array = new double [3,4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FindAverage(array);




void FindAverage(double[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i,j];
        }
        Console.Write($"{Math.Round(result / array.GetLength(0),1),4} \t");
    }
    
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,10);
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],4} \t");
        Console.WriteLine();
    }
}

#endregion