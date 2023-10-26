// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.




// Console.WriteLine("Введите числа через пробел:");
// string input = Console.ReadLine();

// // Разделение строки на отдельные числа
// string[] numbersString = input.Split(' ');

// // Создание массива для хранения целых чисел
// int[] numbers = new int[numbersString.Length];

// // Преобразование строковых значений в целые числа и подсчет количества положительных чисел
// int positiveCount = 0;
// for (int i = 0; i < numbersString.Length; i++)
// {
//     if (int.TryParse(numbersString[i], out int number))
//     {
//         numbers[i] = number;

//         if (number > 0)
//         {
//             positiveCount++;
//         }
//     }
//     else
//     {
//         Console.WriteLine($"Невозможно преобразовать значение \"{numbersString[i]}\" в целое число.");
//         return;
//     }
// }

// // Вывод преобразованных чисел
// Console.WriteLine("Преобразованный массив целых чисел:");
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }

// // Вывод количества положительных чисел
// Console.WriteLine($"Количество положительных чисел: {positiveCount}");




// Console.Write($"Введите числа {str}: ");
// var str = Convert.ToInt32(Console.ReadLine());
// int[] array = str
//     .Select(number => Convert.ToInt32(Char.GetNumericValue(number)))
//     .ToArray();


//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите значения для первой прямой (y = k1 * x + b1):");
Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("\nВведите значения для второй прямой (y = k2 * x + b2):");
Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"\nТочка пересечения двух прямых: ({x}, {y})");








