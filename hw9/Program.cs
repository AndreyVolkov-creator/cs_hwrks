// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());




// int NumListRec(int num)
// {
//     if (num==0) return 0;
//     Console.Write($"{num} ");
//     return NumListRec(num - 1);
// }

// NumListRec(num);

//-----------------------------------------------------------------------

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите первое число");
// int minBorder = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int maxBorder = Convert.ToInt32(Console.ReadLine());




// int SummRec(int num1, int num2)
// {
//     int sum = 0;
//     if(num1>num2) return sum;
//     return sum += num1 + SummRec(num1+1, num2);
// }

// Console.WriteLine(SummRec(minBorder, maxBorder));

//--------------------------------------------------------------------------------------

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());




int AccermanFunc(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if ((num1 != 0) && (num2 == 0)) return AccermanFunc(num1 - 1, 1);
    else return AccermanFunc(num1 - 1, AccermanFunc(num1, num2 - 1));
}

Console.WriteLine(AccermanFunc(firstNum, secondNum));