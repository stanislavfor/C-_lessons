﻿/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите порядковый номер дня недели (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 5)
{
  Console.WriteLine("Нет, этот день недели не выходной");
}
else if (number == 6 || number == 7)
{
  Console.WriteLine("Да, этот день выходной");
}
else
{
  Console.WriteLine("Неверно указан деь недели");
}