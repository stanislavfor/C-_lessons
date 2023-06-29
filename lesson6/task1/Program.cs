// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.Write("Введите первое число:  ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:  ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:  ");
int Number3 = Convert.ToInt32(Console.ReadLine());

if ((Number1 + Number2 > Number3) && (Number1 + Number3 > Number2) && (Number2 + Number3 > Number1)) {
  Console.WriteLine("Такой треугольник возможен");
} 
else 
{
  Console.WriteLine("Несуществующие условия для построения треугольника");
}
