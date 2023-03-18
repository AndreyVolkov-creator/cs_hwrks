#region 1

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

    // int num, degree;

    // Console.WriteLine("Введите число");
    // num = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Введите степень числа");
    // degree = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(NumDegree(num, degree));




    // int NumDegree(int a, int b)
    // {
    //     int i = 0;
    //     int result = 1;
    //     for (i = 1; i <= b; i++)
    //         result *= a;

    //     return result;
    // }
    
#endregion

#region 2
    
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

    // int num;

    // Console.WriteLine("Введите число");
    // num = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(NumSumm(num));




    // int NumSumm(int a)
    // {
    //     int result = 0;
    //     while (a > 0)
    //     {
    //         result += a % 10;
    //         a /= 10;
    //     }

    //     return result;
    // }

#endregion

#region 3
    
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

    Console.WriteLine("Сейчас я создам массив из 8 случайных эллементов");
    int[] array = new int [8];
    FillArray(array);
    PrintArray(array);




    void FillArray(int[] array)
    {
        int i = 0;
        for (i = 0; i < array.Length; i++)
            array[i] = new Random().Next(0, 100);
    }

    void PrintArray(int[] array)
    {
        int i = 0;
        for (i = 0; i <= array.Length - 1; i++)
            Console.Write($"{array[i]} ");
    }

#endregion