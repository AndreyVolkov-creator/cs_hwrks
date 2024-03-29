﻿// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

// int[,] firstArray = new int[2,2];
// int[,] secondArray = new int[2,2];
// int[,] thirdArray = new int[2,2];
// FillArrayThirdTask(firstArray);
// PrintArrayThirdTask(firstArray);
// Console.WriteLine();
// FillArrayThirdTask(secondArray);
// PrintArrayThirdTask(secondArray);
// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         for (int k = 0; k < 2; k++)
//         {
//             thirdArray[i, j] = thirdArray[i, j] + (firstArray[i, k] * secondArray[k, j]);
//         }
//     }
// }
// Console.WriteLine();
// PrintArrayThirdTask(thirdArray);




// void FillArrayThirdTask(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArrayThirdTask(int[,] array)
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
//---------------------------------------------------------------------------------------
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int deep1 = 2;
// int deep2 = 2;
// int deep3 = 2;
// int countNums = 89;
// int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

// for (int i = 0; i < resultNums.GetLength(0); i++)
// {
//     for (int j = 0; j < resultNums.GetLength(1); j++)
//     {
//         for (int k = 0; k < resultNums.GetLength(2); k++)
//         {
//             Console.WriteLine($"{resultNums[i, j, k]} - [{i},{j},{k}]");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }




// int[,,] Create3DMassive(int size1, int size2, int size3)
// {
//     int[,,] array = new int[size1, size2, size3];
//     int[] values = new int[countNums];
//     int num = 10;
//     for (int i = 0; i < values.Length; i++)
//         values[i] = num
//         ++;

//     for (int i = 0; i < values.Length; i++)
//     {
//         int randomInd = new Random().Next(0, values.Length);
//         int temp = values[i];
//         values[i] = values[randomInd];
//         values[randomInd] = temp;
//     }

//     int valueIndex = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = values[valueIndex++];
//             }
//         }
//     }
//     return array;
// }
//---------------------------------------------------------------------------------------
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[,] nums = new int[size, size];
// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArrayFithTask(nums);




// void PrintArrayFithTask(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j],3}  ");
//         }
//         Console.WriteLine();
//     }
// }