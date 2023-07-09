// Задача 3. Напишите программу. которая будет принимать на вход число и возвращать сумму его цифр.
/*
453 - > 12
45-> 9
*/

int SumDigital(int number)
{
  if (number == 0)
  {
    return 0;
  }
  return number % 10 + SumDigital(number / 10);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
Console.Write(SumDigital(number));