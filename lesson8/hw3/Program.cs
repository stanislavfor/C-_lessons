// Задача 3. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел (числа из интервала 10,11, ..98,99). Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

// РЕШЕНИЕ: 

Console.Write("Введите количество СТРОК: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество СТОЛБЦОВ: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество ПОЛЕЙ: ");
int l = Convert.ToInt32(Console.ReadLine());

Console.Write($"Задан трёхмерный массив {m} x {n} x {l}. ");
Console.Write($"Размерность элементов (от - до): индексы строк [0]-[{m-1}], индексы столбцов [0]-[{n-1}], индексы полей [0]-[{l-1}] -> ");


int[,,] array = new int[m, n, l];
// Заполнение массива
int number = 10;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {           
          array[i, j, k] = number++;          
            
        }
    }
}

// Вывод трехмерного массива в консоль
if (number > 99) 
{
  Console.Write("Массив неповторяющихся чисел в указанной размерности НЕ существует. \n'Неповторяющиеся двузначные числа - это числа из интервала 10,11, ..98,99'. \n Укажите другие размеры массива двухзначных неповторяющихся чисел.");
  Console.WriteLine();
}
else 
{
  Console.WriteLine();
  //for (int i = 0; i < array.GetLength(0); i++)
  for (int i = 0; i < m; i++)
  {
    //for (int j = 0; j < array.GetLength(1); j++)
    for (int j = 0; j < n; j++)
    {
      //for (int k = 0; k < array.GetLength(2); k++)
      for (int k = 0; k < l; k++)
      {
        Console.Write($"{array[i, j, k]}({i}, {j}, {k})  ");
      }
      Console.WriteLine();
    }
  }
}

Console.WriteLine();
    

