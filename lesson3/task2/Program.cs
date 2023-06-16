// Методы матиматических вычислений в C# (для урока)

// Возведение в степень
double number = 9;
System.Console.WriteLine(Math.Pow(number, 2));

// Извлечение квадратного корня
System.Console.WriteLine(Math.Sqrt(number));

// Округление дробного числа
double num = 1.123213213213;
System.Console.WriteLine(Math.Round(num, 2));

// Комбинация
System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(num, 3)), 2));
