// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33] 


Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomArray(numbers);
Console.WriteLine("Получаем массив случайных чисел:");
PrintArray(numbers);

void RandomArray(int[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = new Random().Next(1, 10);
  }
}
void PrintArray(int[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
    {
      if (i < numbers.Length - 1)
        Console.Write(numbers[i] + ", ");
      else
        Console.Write(numbers[i] + " ");
    }
  Console.Write(" -> ");
  Console.Write("[ ");
  for (int i = 0; i < numbers.Length; i++)
  {
    if (i < numbers.Length - 1)
      Console.Write(numbers[i] + ", ");
    else
      Console.Write(numbers[i] + " ");
  }
  Console.Write("]");
  Console.WriteLine();
}
