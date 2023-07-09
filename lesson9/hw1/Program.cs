// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int NaturalToLow(int number)
{
  if (number > 0)
  {
    Console.Write($"{number} ");
    NaturalToLow(number - 1);
           
  }
    return number;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {number} -> ");
Console.Write("' ");
NaturalToLow(number);
Console.Write("'");