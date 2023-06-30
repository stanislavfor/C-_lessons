// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12 ] -> 19
// [-4, -6, 89, 6 ] -> 0

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomArray(numbers);
Console.WriteLine("В полученном массиве:");
PrintArray(numbers);
int result = 0;

for (int r = 0; r < numbers.Length; r++)
  if (numbers[r] % 2 != 0)
    result = result + numbers[r];

Console.WriteLine($"сумма нечётных чисел -> {result}");

void RandomArray(int[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = new Random().Next(1, 10);
  }
}
void PrintArray(int[] numbers)
{
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