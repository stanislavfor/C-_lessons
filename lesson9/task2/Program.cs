// Задача 2. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
M = 1; N = 5-> "1, 2, 3, 4, 5"
M = 4; N = 8-> "4, 6, 7, 8"
*/

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(m, n);

void NaturalNumbers(int m, int n)
{
  if (n == m)
  {
    Console.Write($"{n} ");
    return;
  }
  NaturalNumbers(m, n-1);
  Console.Write($"{n} ");  
}

