// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] arr = new int[8];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
  arr[i] = rnd.Next(0, 2);
  // System.Console.Write($"{arr[i]} ");
}

// for (int i = 0; i < arr.Length - 1; i++)
// {
// System.Console.Write($"{arr[i]}; ");
// }
// System.Console.Write($"{arr[arr.Length - 1]}");

// System.Console.WriteLine();
System.Console.WriteLine($"[{string.Join("; ", arr)}]");


