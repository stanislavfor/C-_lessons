﻿// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
N = 5-> "1, 2, 3, 4, 5"
N = 6-> "1, 2, 3, 4, 5,6"
*/


void RoadToNumber(int number)
{  
  if (number == 0)
  {
    return;
  }
  
  RoadToNumber(number - 1);
  Console.Write($"{number} ");
  
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {number} -> ");
Console.Write("' ");
RoadToNumber(number);
Console.Write("'");