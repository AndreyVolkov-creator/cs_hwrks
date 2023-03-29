#region 1

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите кол-во строк массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массива");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = new double [rows, columns];
FillArray(array);
PrintArray(array);




double RandomDouble(double minValue, double maxValue)
{
    Random random = new Random();

	return minValue + (maxValue - minValue) * random.NextDouble();
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Math.Round(RandomDouble(-10, 11),1);
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j], 4} \t");
        Console.WriteLine();
    }
}

#endregion

#region 2
    
#endregion

#region 3
    
#endregion

#region 4

// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

// Console.WriteLine("Введите кол-во строк массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int [rows, columns];
// FillArray(array);
// PrintArray(array);


// void SortArrayIndex(int[,] array)
// {
//     int min = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             if (array[i,j] < min) 
//             {}

//     foreach (var item in array)
//     {
//         if (array[i,j] < item) array[i,j] = item;

//     }
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(0, 21);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j], 3} \t");
//         Console.WriteLine();
//     }
// }
    
#endregion
