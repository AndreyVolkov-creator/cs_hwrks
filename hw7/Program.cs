double RandomDouble(double minValue, double maxValue)
{
    Random random = new Random();

	return minValue + (maxValue - minValue) * random.NextDouble();
}

void FillArrayFirstTask(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Math.Round(RandomDouble(-10, 11),1);
}

void PrintArrayFirstTask(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j], 4} \t");
        Console.WriteLine();
    }
}

int[] FindNumIndex(int[,] array, int userValue)
{
    int rowResult = 0;
    int colResult = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == userValue)
            {
                rowResult = i;
                colResult = j;
                goto Found;
            }
            else if (userValue > 9) Console.WriteLine("Вы ввели число, которого нет в массиве");

        }
    Found:       
    int[] result = {rowResult+1, colResult+1};
    return result;
}

void FillArraySecondtTask(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0,10);
}

void PrintArraySecondtTask(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j], 2} \t");
        Console.WriteLine();
    }
}

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

void FillArrayThirdTask(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,10);
}

void PrintArrayThirdTask(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],4} \t");
        Console.WriteLine();
    }
}





Console.WriteLine("Выберите, какую задачу вы хотите посмотреть, 1, 2 или 3?");
string choice = String.Empty;
choice = Console.ReadLine()!; 

if (choice == "1")
{
    Console.WriteLine("ЗАДАНИЕ: Задайте двумерный массив своими размерами, заполненный случайными вещественными числами.");
    Console.WriteLine("Введите кол-во строк массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов массива");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] arrayFirstTask = new double [rows, columns];
    FillArrayFirstTask(arrayFirstTask);
    PrintArrayFirstTask(arrayFirstTask);
}
else if(choice == "2")
{
    Console.WriteLine("ЗАДАНИЕ: Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.");
    Console.WriteLine("Массив будет заполнен числами от 0 до 9. Введите, какое число вы хотите найти?");
    int findNum = Convert.ToInt32(Console.ReadLine());

    int[,] arraySecondtTask = new int [5,5];
    FillArraySecondtTask(arraySecondtTask);
    PrintArraySecondtTask(arraySecondtTask);
    int[] userNumIndex = FindNumIndex(arraySecondtTask, findNum);
    Console.WriteLine($"Ваше число находится на {userNumIndex[0]} строке, в {userNumIndex[1]} столбце");
}
else if(choice == "3")
{
    Console.WriteLine("ЗАДАНИЕ: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    double[,] arrayThirdTask = new double [3,4];
    FillArrayThirdTask(arrayThirdTask);
    PrintArrayThirdTask(arrayThirdTask);
    Console.WriteLine();
    FindAverage(arrayThirdTask);
}
else Console.WriteLine("Вы ввели неверное число");