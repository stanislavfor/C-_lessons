﻿// // Задача 3. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза



void FillMatrixWithRandom(int[,] matrix)
{
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(0, 10);
    }
  }
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{matrix[i, j]} \t");
    }
    System.Console.WriteLine();
  }
}

System.Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);

int min = matrix[0, 0];
int max = matrix[0, 0];
int count = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    if (min > matrix[i, j])
    {
      min = matrix[i, j];
    }
    if (max < matrix[i, j])
    {
      max = matrix[i, j];
    }

  }
}

for (int k = min; k <= max; k++)
{
  count = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] == k)
      {
        count++;
      }
    }
  }
  if (count > 0)
  {
    System.Console.WriteLine($"Количествр во повторений для {k} = {count}");
  }
}
