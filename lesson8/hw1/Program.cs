// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// РЕШЕНИЕ:

Console.Write("Введите количество СТРОК массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество СТОЛБЦОВ массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

// Метод создания двумерного массива случайным выбором
void arraySet(int m, int n)
{
  int i,j;
  Random randomArraySet = new Random();
  for (i = 0; i < m; i++)
  {
    for (j = 0; j < n; j++)
    {
      randomArray[i,j] = randomArraySet.Next(1,9);
    }
  }
}

// Метод вывода полученного двумерного массива в консоль
void printArray(int[,] array)
{
  int i,j;
  for (i = 0; i < array.GetLength(0); i++)
  {    
    for (j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i,j]}  ");
    }
      Console.WriteLine();
  }
}


// Метод упорядочивания по убыванию элементов каждой строки двумерного массива
void itemSorting (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

arraySet(m,n);
Console.WriteLine("Задан массив: ");
printArray(randomArray);

itemSorting(randomArray);
Console.WriteLine("Упорядочиваем по убыванию элементы каждой строки.");
Console.WriteLine("В итоге получаем вот такой массив: ->");
printArray(randomArray);

Console.WriteLine();