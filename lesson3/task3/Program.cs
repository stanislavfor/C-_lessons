/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1, 4 */

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Таблица квадратов (чисел от 1 до {number}) для {number}: -> ");

for (int power = 1; power <= number; power++) {
  Console.Write($"{(int)Math.Pow(power, 2)}, ");
}



