/*Задача 2. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

System.Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
GetBinaryView(number);


void GetBinaryView(int num)
{
  if (num == 0)
  {
    return;
  }
  GetBinaryView(num / 2);
  int Check = num % 2;  
  System.Console.Write(Check);
}

System.Console.Write($" - двоичный код числа {number}");
