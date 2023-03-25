// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями:

// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double num1b = vvediteDouble("Введите координату первой точки по b:");
double num1k = vvediteDouble("Введите координату первой точки по k:");
double num2b = vvediteDouble("Введите координату второй точки по b:");
double num2k = vvediteDouble("Введите координату второй точки по k:");

double x = calculateX(num1b, num1k, num2b, num2k);

  // y = k1 * x + b1, y = k2 * x + b2; 
  double y = num1k * x + num1b;



double xRound = Math.Round(x, 2);
double yRound = Math.Round(y, 2);
Console.WriteLine($"y = {num1k} * x + {num1b}, y = {num2k} * x + {num2b};");
Console.WriteLine($"Точка пересечения двух прямых ({xRound}; {yRound})");



double vvediteDouble(string message)
{
  Console.Write(message);
  return Convert.ToDouble(Console.ReadLine());
}


double calculateX(double b1, double k1, double b2, double k2)
{
  double x = (b2 - b1) / (k1 - k2);
  return x;
}

