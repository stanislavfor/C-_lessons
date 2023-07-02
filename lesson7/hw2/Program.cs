// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа НЕТ в массиве


int m = 3; // Количество строк
int n = 4; // Количество столбцов
// Выводим рандомный массив
Random random = new Random();
int[,] arr = new int[m, n];
Console.WriteLine("Задан исходный массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    arr[i, j] = random.Next(10, 99);
    Console.Write("{0} ", arr[i, j]);
  }
  Console.WriteLine();
}

Console.Write("Введите строку: ");
int mNumber = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int nNumber = Convert.ToInt32(Console.ReadLine()) - 1;

if (mNumber < 0 | mNumber > arr.GetLength(0) - 1 | nNumber < 0 | nNumber > arr.GetLength(1) - 1)
{
  Console.WriteLine("Такого числа НЕТ в массиве");
}
else
{
  Console.WriteLine("Найден элемент массива -> {0}", arr[mNumber, nNumber]);
}
//Console.ReadLine();
Console.WriteLine();
