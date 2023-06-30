// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
//1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 ^ 2 4 49 2
// 5 81 2 9
// 64 4 4 4



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

void SquareEvenElement(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i += 2)
  {
    for (int j = 0; j < matrix.GetLength(1); j += 2)
    {
      matrix[i, j] *= matrix[i, j];
    }
  }
}

System.Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
SquareEvenElement(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);


