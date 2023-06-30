// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2-> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите несколько чисел (через пробел): ");
int[] num = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
int result = 0;

for (int i = 0; i < num.Length; i++)
{
  if (num[i] > 0)
  {
    result++;
  }
}

Console.Write("В массиве из чисел [ ");
for (int i = 0; i < num.Length; i++)
{  
  Console.Write($"{num[i]} ");
}

Console.WriteLine($"] -> количество элементов больше `0` = {result}");
