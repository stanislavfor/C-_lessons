// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
RandomArray(numbers);
Console.WriteLine("В полученном массиве");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int r = 0; r < numbers.Length; r++)
{
  if (numbers[r] > max)
  {
    max = numbers[r];
  }
  if (numbers[r] < min)
  {
    min = numbers[r];
  }
}

Console.WriteLine($"максимальное число => {max}, минимальное число => {min}");
Console.WriteLine($"Разница значений {max} - {min} = {Math.Round((max - min),2)}");

void RandomArray(double[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
  }
}
void PrintArray(double[] numbers)
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