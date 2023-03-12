#region 1
    
    // int num, result;

    // Console.WriteLine("Введите трехзначное число");
    // num = Convert.ToInt32(Console.ReadLine());

    // if (num > 99 && num < 1000)
    //     {
    //         while (num >= 100) num /= 10;
    //         result = num%10;
    //         Console.WriteLine($"Вторая цифра вашего числа {result}");
    //     }
    // else Console.WriteLine("Введено неверное число");

#endregion

#region 2
    
    int num, result;

    Console.WriteLine("Введите ваше число");
    num = Convert.ToInt32(Console.ReadLine());

    if (num > 99)
        {
            while (num >= 1000) num /= 10;
            result = num%10;
            Console.WriteLine($"Тертья цифра вашего числа {result}");
        }
    else Console.WriteLine("Введено неверное число");

#endregion

#region 3
    
#endregion