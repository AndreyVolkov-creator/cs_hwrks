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
    
    // int num, result;

    // Console.WriteLine("Введите ваше число");
    // num = Convert.ToInt32(Console.ReadLine());

    // if (num > 99)
    //     {
    //         while (num >= 1000) num /= 10;
    //         result = num%10;
    //         Console.WriteLine($"Тертья цифра вашего числа {result}");
    //     }
    // else Console.WriteLine("Введено неверное число");

#endregion

#region 3
    
    int num;

    Console.WriteLine("Введите ваше число");
    num = Convert.ToInt32(Console.ReadLine());

    if (num > 0 && num < 8)
        if (num == 6 || num == 7)
            {
                Console.WriteLine("Вы указали выходной день");
            }  
        else Console.WriteLine("Вы указали будний день");       
    else Console.WriteLine("Вы не правильно указали день недели");

#endregion