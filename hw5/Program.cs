#region 1

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Кол-во четных эллементов массива равно {NumP(array)}");




void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int NumP(int[] array)
{
    int result = 0;
    foreach (int item in array)
    {
        if(item % 2 == 0) result++;
    }
    return result;
}
    
#endregion

#region 2
    
#endregion

#region 3
    
#endregion