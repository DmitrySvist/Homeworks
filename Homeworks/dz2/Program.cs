// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// int degree (int a, int b)
// {
//  int deg = 1;
//  for (int i = 1; i <= b; i++)
//  {
//     deg = deg*a;
    
//  } 
//  return deg;
// }

// System.Console.Write("input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("input B:");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine (degree(a,b));



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int summ ( int number)
// {
//  int sum =0;
//  while (number !=0)
//  {
//     int digit = number%10;
//     sum = sum + digit;
//     number/=10;
    
//  } 
//  return sum;
// }

// System.Console.Write("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine (summ(number));


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] RandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next(minValue, maxValue + 1);
    }
    return array;
}   

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input minimal value:");
int minValue = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input maximal value:");
int maxValue = Convert.ToInt32(Console.ReadLine());

 PrintArray(RandomArray( size, minValue, maxValue));

