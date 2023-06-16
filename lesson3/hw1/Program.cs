/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212->нет
12821->да
23432->да */

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int val = number.ToString().Length;

if (val == 5) {
  if ((number / 10000 == number % 10) && ((number / 1000) % 10 == (number % 100) / 10))
    {
      Console.WriteLine($"Ваше число {number} -> да, Это палиндром");
    }
    else
    {
      Console.WriteLine($"Ваше число {number} -> нет, Это НЕ палиндром");
    }
}
else 
{
  Console.WriteLine("Число указано неправильно");
}


