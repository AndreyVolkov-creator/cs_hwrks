#region 1
    


#endregion

#region 2
    


#endregion

#region 3
    
    int num;

    Console.WriteLine("Введите ваше число");
    num = Convert.ToInt32(Console.ReadLine());
    cubeNum(num);



    
    void cubeNum(int num)
    {
        int i, result;
        for(i=1; i<=num; i++)
        {
            result = i * i * i;
            Console.WriteLine(result);
        }

    }

#endregion