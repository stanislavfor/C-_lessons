// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33] 

double[] array = new double[8];
Console.WriteLine("Введите массив чисел (до восьми элементов массива): ");

for (int i = 0; i < 8; i++)
{
  array[i] = Convert.ToDouble(Console.ReadLine());
}


Console.WriteLine("[");
for (int i = 0; i < 8; i++)
//{
// arr[i] = int.Parse(Console.ReadLine());
//}

//for (int i = 0; i < arr.Length-1; i++)
//{
//  Console.WriteLine(arr[i] + " ");
//}

Console.WriteLine(string.Join(", ", array));

