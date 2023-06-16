// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/* A(3, 6, 8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53 */

Console.Write("Введите координату X точки A: ");
int xNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
int yNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
int zNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int xNumberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int yNumberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int zNumberB = Convert.ToInt32(Console.ReadLine());


int x = xNumberB - xNumberA;
int y = yNumberB - yNumberA;
int z = zNumberB - zNumberA;
double result = Math.Round(Math.Sqrt((x * x) + (y * y) + (z * z)), 2);

System.Console.Write($"Расстояние между точками A и B в 3D пространстве равно -> {result}");
