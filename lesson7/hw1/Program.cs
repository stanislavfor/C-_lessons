// Задача 1. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 - 2 - 0,2
// 1 - 3,3 8 - 9,9
// 8 7,8 - 7,1 9

// Задаем размеры массива
int m = 3; // Количество строк
int n = 4; // Количество столбцов

// Создаем двумерный массив
double[,] array = new double[m, n];

// Создаем экземпляр класса Random
Random random = new Random();

// Заполняем массив случайными вещественными числами
for (int i = 0; i < m; i++)
{
  for (int j = 0; j < n; j++)
  {
    // Генерируем случайное вещественное число от -10 до 10
    double randomNumber = random.NextDouble() *10;
    array[i, j] = randomNumber;    
  }
}

// Выводим массив на консоль
for (int i = 0; i < m; i++)
{
  for (int j = 0; j < n; j++)
  {
    //Console.Write((array[i, j] + "  "));

    // Форматируем дробные чисела    
    Console.Write(String.Format("{0:N}", array[i, j]));
    Console.Write("  ");
  }
  Console.WriteLine();
}

// Ожидаем нажатия клавиши перед завершением программы
//Console.ReadKey();

 