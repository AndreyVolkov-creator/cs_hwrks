// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] array = new int[4, 4];
// FillArrayFirstTask(array);
// PrintArrayFirstTask(array);
// Console.WriteLine();
// Sort(array);
// PrintArrayFirstTask(array);




// void Sort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int z = 0; z < array.GetLength(1) - 1; z++)
//             {
//                 if (array[i, z] < array[i, z + 1]) 
//                 {
//                     int temp = 0;
//                     temp = array[i, z];
//                     array[i, z] = array[i, z + 1];
//                     array[i, z + 1] = temp;
//                 }
//             }
//         }
//     }
// }

// void FillArrayFirstTask(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArrayFirstTask(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine("");
//     }
// }
//---------------------------------------------------------------------------------------------------------------------
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] array = new int[3,2];
// FillArraySecondTask(array);
// PrintArraySecondTask(array);
// int minSum = Int32.MaxValue;
// int rowNumber = 0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];        
//     }
//     if (sum < minSum)
//     {
//         minSum = sum;
//         rowNumber++;
//     }
// }
// Console.WriteLine($"строка с наименьшей суммой елементов: {rowNumber}, с суммой елементов равной {minSum}");




// void FillArraySecondTask(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArraySecondTask(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine("");
//     }
// }
//-------------------------------------------------------------------------------------------------
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstArray = new int[2,2];
int[,] secondArray = new int[2,2];
int[,] thirdArray = new int[2,2];
FillArrayThirdTask(firstArray);
PrintArrayThirdTask(firstArray);
Console.WriteLine();
FillArrayThirdTask(secondArray);
PrintArrayThirdTask(secondArray);
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            thirdArray[i, j] = thirdArray[i, j] + (firstArray[i, k] * secondArray[k, j]);
        }
    }
}
Console.WriteLine();
PrintArrayThirdTask(thirdArray);




void FillArrayThirdTask(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArrayThirdTask(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine("");
    }
}