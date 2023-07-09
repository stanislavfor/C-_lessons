// Задача 4. Напишите программу, которая на вход принимает два числа A и B, и выводит число A в целую степень B с помощью рекурсии.
/*
A = 3; B = 5-> 243(3 ^ 5)
A = 2; B = 3-> 8;
*/


Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

// Метод возведения в степень
int powNumber(int a, int b)
{
  if (b == 0)
  {
    return 1;
  }
return a * powNumber(a, b - 1);
}

Console.WriteLine($"A = {a}; B = {b} -> {powNumber(a, b)} ({a}^{b})");