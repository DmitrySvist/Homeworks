// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// int task1 (string thr)
// {
// System.Console.Write(thr);
// string value = Console.ReadLine();
// int num = Convert.ToInt32(value);
// return num;
// }
// int number = task1("Введите трехзначное число >");
// if (number>=100 && number <=999)
// {
//     System.Console.WriteLine($"Введенное число {number}");
//     System.Console.WriteLine($"Вторая цифра {(number % 100 - number % 10) / 10}");
// }
// else 
// {
//      System.Console.WriteLine($"Число {number} не трёхзначное!");
// }










// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// int task2 (string number)
// {
// System.Console.Write(number);
// string value = Console.ReadLine();
// int num = Convert.ToInt32(value);
// return num;
// }
//  int number = task2("Введите число >");
// if (number>=100)
// {
//     System.Console.WriteLine($"Введенное число {number}");
//     System.Console.WriteLine($"Третья цифра  {(number % 1000 - number % 100) / 100}");
// }
// else 
// {
//      System.Console.WriteLine($"{number} -> Третьей цифры нет");
// }





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет




int week (string number)
{
System.Console.Write(number);
string value = Console.ReadLine();
int num = Convert.ToInt32(value);
return num;
}
string IsWeekend (int weekD)
{
   string day = "Это не день недели";
     if (weekD > 5 && weekD <=7) day = "Это выходной";
     if (weekD >= 1 && weekD <6) day = "Это будний день";
     return day;
}


int weekD = week("Введите день недели >");
string df = IsWeekend (weekD);
System.Console.WriteLine(df);





