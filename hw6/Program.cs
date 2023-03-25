#region 1

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 5
// 1, -7, 567, 89, 223-> 3 

Console.WriteLine("Сколько чисел вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Вы ввели {PositiveNums(array)} чисел больше 0");




int PositiveNums(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }

    return result;
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }  
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

#endregion

#region 2
    
#endregion