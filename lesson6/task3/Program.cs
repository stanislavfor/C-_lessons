/*Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5-> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */


int n1 = 0, n2 = 1, n3, i, number;

Console.Write("Введите число N: ");
number = Convert.ToInt32(Console.ReadLine());

Console.Write("Если N = {0} -> Числа Фибоначчи от 0 до {0}: ", number);

Console.Write(" " + n1 + " " + n2);


for (i = 2; i <= number-1; ++i)
{
  n3 = n1 + n2;
  Console.Write(" " + n3);
  n1 = n2;
  n2 = n3;
}