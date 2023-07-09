// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// РЕШЕНИЕ:

Console.Write("Введите количество СТРОК массива: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество СТОЛБЦОВ массива: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[rowCount, columnCount];

//Создаем 'спиральный массив' и заполним его значениями
Console.WriteLine($"Создаем 'спиральный массив' размером {rowCount} на {columnCount}.");
int[,] array = new int[rowCount, columnCount];
int counter = 1;
for (int row = 0; row < rowCount; row++)
{
  for (int column = 0; column < columnCount; column++)
  {
    array[row, column] = counter++;
  }
}

// Определим переменные, которые будут задавать границы выхода за пределы массива
int left = 0;
int right = columnCount - 1;
int top = 0;
int bottom = rowCount - 1;
int value = 1;

// Выводим значения массива по спирали
while (left <= right && top <= bottom)
{
  // Шаг вправо
  for (int column = left; column <= right; column++)
  {    
    array[top, column] = value++;
  }
  top++;

  // Шаг вниз
  for (int row = top; row <= bottom; row++)
  {    
    array[row, right] = value++;
  }
  right--;

  // Шаг влево
  if (top <= bottom)
  {
    for (int column = right; column >= left; column--)
    {      
      array[bottom, column] = value++;
    }
    bottom--;
  }

  // Шаг вверх
  if (left <= right)
  {
    for (int row = bottom; row >= top; row--)
    {      
      array[row, left] = value++;
    }
    left++;
  }
}


// Выводим двумерный массив в консоль
Console.WriteLine($"Выводим двумерный массив с числами от 1 до {value - 1}: ->");
for (int i = 0; i < rowCount; i++)
{
  for (int j = 0; j < columnCount; j++)
  {
    Console.Write(array[i, j] + " ");
  }
  Console.WriteLine();
}

Console.WriteLine();