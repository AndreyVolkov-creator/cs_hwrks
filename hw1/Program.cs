#region 1

    // int a, b;

    // Console.WriteLine("Введите первое число");
    // a = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Введите второе число");
    // b = Convert.ToInt32(Console.ReadLine());

    // if (a > b) Console.WriteLine(a);
    // else Console.WriteLine(b);
    
#endregion

#region 2

    int a, b, c;

    Console.WriteLine("Введите первое число");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    c = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine(Math.Max(a, Math.Max(b, c)));

#endregion