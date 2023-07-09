// Задача 4. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// РЕШЕНИЕ:

// Ввод размерности массивов
Console.Write("Введите количество СТРОК массива A: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество СТОЛБЦОВ первого массива A: ");
int cols1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество СТРОК второго массива B: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество СТОЛБЦОВ второго массива B: ");
int cols2 = Convert.ToInt32(Console.ReadLine());

// Создание двух массивов
int[,] array1 = new int[rows1, cols1];
int[,] array2 = new int[rows2, cols2];   

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


// Проверка возможности умножения массивов
if (cols1 != rows2)
{
    Console.WriteLine("Умножение данных массивов невозможно");
    return;
}

// Создание результирующего массива
int[,] resultArray = new int[rows1, cols2];


// Умножение массивов
for (int i = 0; i < rows1; i++)
{
  for (int j = 0; j < cols2; j++)
  {
    for (int k = 0; k < cols1; k++)
    {
      resultArray[i, j] += array1[i, k] * array2[k, j];
    }
  }
}

// Вывод результата
Console.WriteLine("Результат умножения двух массивов:");
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        Console.Write(resultArray[i, j] + " ");
    }
    Console.WriteLine();
}

   