//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string ReverseCount(int n)
// {
//     if (n == 1)
//     {
//         return "1";
//     }

//     return n + " " + ReverseCount(n - 1);
// }

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(ReverseCount (n));


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumToN(int m, int n)
// {
//     if (m > n)
//         return 0;

//     return m + SumToN(m + 1, n);
// }

// System.Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SumToN(m, n));

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int AckermannFunction(int m, int n)
{   if (m < 0 || n < 0)
{
  Console.WriteLine($"A({m}, {n}) = m и n не могут быть отрицательными");
  return -1;
}

     
    else if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

System.Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine()); ;

Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");