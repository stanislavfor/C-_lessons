/*Напишите программу, которая прингимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125 */

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Таблица кубов (чисел от 1 до {number}) для {number}: -> ");

for (int power = 1; power <= number; power++)
{
  Console.Write($"{(int)Math.Pow(power, 3)}, ");
}
