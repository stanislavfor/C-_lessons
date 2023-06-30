// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomArray(numbers);
Console.WriteLine("В полученном массиве:");
PrintArray(numbers);
int result = 0;

for (int r = 0; r < numbers.Length; r++)
  if (numbers[r] % 2 == 0)
    result++;

Console.WriteLine($"количество чётных чисел -> {result}");

void RandomArray(int[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = new Random().Next(100, 1000);
  }
}
void PrintArray(int[] numbers)
{
  Console.Write("[ ");
  for (int i = 0; i < numbers.Length; i++)
  {
    if (i < numbers.Length-1)
      Console.Write(numbers[i] + ", ");
    else
      Console.Write(numbers[i] + " ");
  }
  Console.Write("]");
  Console.WriteLine();
}