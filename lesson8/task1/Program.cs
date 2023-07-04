// Задача 53: Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива.



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

System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);

int temp = 0;

for (int j = 0; j < matrix.GetLength(1); j++)
{
  temp = matrix[0, j];
  matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
  matrix[matrix.GetLength(0) - 1, j] = temp;
}

System.Console.WriteLine();
PrintMatrix(matrix);