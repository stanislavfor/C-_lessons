/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Введите число : ");

int number = Convert.ToInt32(Console.ReadLine());

if ((number >= 100))
{
  string StringNumber = "";
  StringNumber = Convert.ToString(number);
 
  Console.WriteLine($"Третья цифра этого числа : {(StringNumber[2])}");
}
else
{
  Console.WriteLine("В этом числе третьей цифры нет");
}