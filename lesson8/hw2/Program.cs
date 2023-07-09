// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// РЕШЕНИЕ :

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


// Считаем сумму элементов в каждой строке массива
void rowSumMin()
{
int minTotal = int.MaxValue;
int minRow = 0; 
for (int i = 0; i < m; i++)
{
  int rowSum = 0;
  for (int j = 0; j < n; j++)
      rowSum += randomArray[i, j];  
  if (rowSum < minTotal)
  {
      minTotal = rowSum;
      minRow = i;

  }
}
Console.WriteLine($"-> строка {minRow + 1}");
}


arraySet(m, n);
Console.WriteLine("Задан массив: ");
printArray(randomArray);
Console.WriteLine("Строка c наименьшей суммой элементов:");    
rowSumMin();
Console.WriteLine();