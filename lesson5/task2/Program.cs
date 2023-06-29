﻿// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] FillArrayWithRandomNumber(int size)
{
  int[] arr = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(-9, 10);
  }
  return arr;
}

int[] Reveret(int[] arr)
{
  int[] newArr = new int[arr.Length];
  for (int i = 0; i < newArr.Length; i++)
  {
    newArr[i] = -arr[i];
  }
  return newArr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

int[] newArr = Reveret(array);
System.Console.WriteLine(string.Join("; ", newArr));
