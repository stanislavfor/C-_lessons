﻿// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456-> 3
// 78-> 2
// 89126-> 5



// int CountingDigit(int num)
// {
// int count = 0;
// while (num > 0)
// {
// num /= 10;
// count++;
// }
// return count;
// }

// Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// if (CountingDigit(number) == 0)
// {
// System.Console.WriteLine("1");
// }
// else
// {
// System.Console.WriteLine(CountingDigit(number));
// }

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string num = number.ToString();
System.Console.WriteLine($"Количество цифр в числе -> {num.Length}");


