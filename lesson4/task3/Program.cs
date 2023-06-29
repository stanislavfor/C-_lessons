﻿// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4-> 24
// 5-> 120

int Multiply(int num)
{
  int mult = 1;
  for (int i = 1; i <= num; i++)
  {
    mult *= i; // == sum = sum + i;
  }
  return mult;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведение чисел от 1 до {number} = {Multiply(number)}");
