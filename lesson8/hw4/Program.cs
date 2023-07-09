// Задача 4. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// РЕШЕНИЕ:

Console.Write("Найдите произведение двух матриц A и B.");
printRule();

void printRule() 
{
  System.Console.WriteLine(" Произведение двух матриц A и B возможно при условии, \nкогда количество СТОЛБЦОВ матрицы A равно количеству СТРОК матрицы B.");
}

// Ввод размерности массивов
System.Console.Write("Введите количество СТРОК матрицы A: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество СТОЛБЦОВ матрицы A: ");
int cols1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество СТРОК матрицы B: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество СТОЛБЦОВ матрицы B: ");
int cols2 = Convert.ToInt32(Console.ReadLine());

// Создание двух массивов
int[,] array1 = new int[rows1, cols1];
int[,] array2 = new int[rows2, cols2];

MatrixRandom1(array1);
MatrixRandom2(array2);
PrintMatrix1(array1);
PrintMatrix2(array2);

/*
// Ввод элементов первого массива A
Console.WriteLine("Введите элементы первого массива A:");
for (int i = 0; i < rows1; i++)
{
  for (int j = 0; j < cols1; j++)
  {
    Console.Write($"Элемент [{i}, {j}]: ");
    array1[i, j] = Convert.ToInt32(Console.ReadLine());
  }
}

// Ввод элементов второго массива B
Console.WriteLine("Введите элементы второго массива B:");
for (int i = 0; i < rows2; i++)
{
  for (int j = 0; j < cols2; j++)
  {
    Console.Write($"Элемент [{i}, {j}]: ");
    array2[i, j] = Convert.ToInt32(Console.ReadLine());
  }
}
*/
// Создание случайным набором двух матриц и вывод их в консоли
void MatrixRandom1(int[,] array1)
{
  Random rnd = new Random();
  for (int i = 0; i < array1.GetLength(0); i++)
  {
    for (int j = 0; j < array1.GetLength(1); j++)
    {
      array1[i, j] = rnd.Next(0, 10);
    }
  }
}

void MatrixRandom2(int[,] array2)
{
  Random rnd = new Random();
  for (int i = 0; i < array2.GetLength(0); i++)
  {
    for (int j = 0; j < array2.GetLength(1); j++)
    {
      array2[i, j] = rnd.Next(0, 10);
    }
  }
}

void PrintMatrix1(int[,] array1)
{
  System.Console.WriteLine("Задана матрица A: ");
  for (int i = 0; i < array1.GetLength(0); i++)
  {
    for (int j = 0; j < array1.GetLength(1); j++)
    {
      System.Console.Write($"{array1[i, j]}\t");
    }
  //System.Console.WriteLine();
    whiteSpace();
  }
}

void PrintMatrix2(int[,] array2)
{
  System.Console.WriteLine("Задана матрица B: ");
  for (int i = 0; i < array2.GetLength(0); i++)
  {
    for (int j = 0; j < array2.GetLength(1); j++)
    {
      System.Console.Write($"{array2[i, j]}\t");
    }
    //System.Console.WriteLine();
    whiteSpace();
  }
}


// Проверка возможности умножения массивов
if (cols1 != rows2)
{
    System.Console.Write("Умножение данных матриц НЕВОЗМОЖНО.");
    printRule();
    whiteSpace();
    return;
}

// Создание результирующего массива
int[,] resultMatrix = new int[rows1, cols2];

// Умножение массивов
for (int i = 0; i < rows1; i++)
{
  for (int j = 0; j < cols2; j++)
  {
    for (int k = 0; k < cols1; k++)
    {
      resultMatrix[i, j] += array1[i, k] * array2[k, j];
    }
  }
}

// Вывод результата умножения двух матрицы A и матрицы B
System.Console.WriteLine("Результат умножения матрицы A и матрицы B: ->");
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
    System.Console.Write($"{resultMatrix[i, j]} \t");
    }
  //System.Console.WriteLine();
    whiteSpace();
}

void whiteSpace() {
  System.Console.WriteLine();  
}

whiteSpace();