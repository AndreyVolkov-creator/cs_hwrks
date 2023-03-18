#region 1

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

    int num, degree;

    Console.WriteLine("Введите число");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа");
    degree = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(NumDegree(num, degree));




    int NumDegree(int a, int b)
    {
        int i = 0;
        int result = 1;
        for (i = 1; i <= b; i++)
            result *= a;

        return result;
    }
    
#endregion

#region 2
    
#endregion

#region 3
    
#endregion