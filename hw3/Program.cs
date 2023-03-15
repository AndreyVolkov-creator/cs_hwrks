#region 1
    
    int num, revNum = 0;

    Console.WriteLine("Введите птяизачное число");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(CompareNum(num, ReverseNum(num)));




    int ReverseNum(int num)
    {
        int result = 0;
        while(num > 0)
        {
            revNum *= 10;
            revNum += num % 10;
            num /= 10;
        }
        result = revNum;
        return result;
    }

    string CompareNum(int num1, int num2)
    {
        if(num1 == num2) return "Yes";
        else return "No";
    }

#endregion

#region 2
    
    // double x1, x2, z1, y1, y2, z2, dist1, dist2, dist3, dist;

    // Console.WriteLine("Введите х1");
    // x1 = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine("Введите y1");
    // y1 = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine("Введите z1");
    // z1 = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine("Введите x2");
    // x2 = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine("Введите y2");
    // y2 = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine("Введите z2");
    // z2 = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine(distance(x1,y1,z1,x2,y2,z2));




    // double distance(double x1, double y1, double z1, double x2, double y2, double z2)
    // {
    //     dist1 = (x2 - x1) * (x2 - x1);
    //     dist2 = (y2 - y1) * (y2 - y1);
    //     dist3 = (z2 - z1) * (z2 - z1);
    //     dist = Math.Sqrt(dist1 + dist2 + dist3);
    //     return dist;
    // }

#endregion

#region 3
    
    // int num;

    // Console.WriteLine("Введите ваше число");
    // num = Convert.ToInt32(Console.ReadLine());
    // cubeNum(num);



    
    // void cubeNum(int num)
    // {
    //     int i, result;
    //     for(i=1; i<=num; i++)
    //     {
    //         result = i * i * i;
    //         Console.WriteLine(result);
    //     }

    // }

#endregion