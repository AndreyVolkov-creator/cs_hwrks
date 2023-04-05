int NumListRec(int num)
{
    if (num==0) return 0;
    Console.Write($"{num} ");
    return NumListRec(num - 1);
}

int SummRec(int num1, int num2)
{
    int sum = 0;
    if(num1>num2) return sum;
    return sum += num1 + SummRec(num1+1, num2);
}

int AccermanFunc(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if ((num1 != 0) && (num2 == 0)) return AccermanFunc(num1 - 1, 1);
    else return AccermanFunc(num1 - 1, AccermanFunc(num1, num2 - 1));
}




Console.WriteLine("Выберите, какую задачу вы хотите посмотреть, 1, 2 или 3?");
string choice = String.Empty;
choice = Console.ReadLine()!; 

if (choice == "1")
{
    Console.WriteLine("ЗАДАНИЕ: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    NumListRec(num);
}
else if(choice == "2")
{
    Console.WriteLine("ЗАДАНИЕ: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    Console.WriteLine("Введите первое число");
    int minBorder = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int maxBorder = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SummRec(minBorder, maxBorder));
}
else if(choice == "3")
{
    Console.WriteLine("ЗАДАНИЕ: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    Console.WriteLine("Введите первое число");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int secondNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(AccermanFunc(firstNum, secondNum));
}
else Console.WriteLine("Вы ввели неверное число");