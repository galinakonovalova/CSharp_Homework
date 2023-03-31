// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
  var rnd = new Random();
  var matrix = new int[rows, columns];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }

  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],4} ");
    }
    Console.WriteLine("|");
  }
}

double[] Avg(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int cols = matrix.GetLength(1);
  double[] result = new double[cols];
  for (int j = 0; j < cols; j++)
  {
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
      sum += matrix[i, j];
    }
    result[j] = Math.Round(sum / rows, 2);
  }
  return result;
}

void printDouble(double[] array)
{
  foreach (double v in array)
  {
    System.Console.Write($"{v} ");
  }
}

var matrix = CreateMatrix(3, 4, 0, 10);
PrintMatrix(matrix);

double[] r = Avg(matrix);
printDouble(r);