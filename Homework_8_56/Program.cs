// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

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

int[] Sum(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int cols = matrix.GetLength(1);
  int[] result = new int[rows];
  for (int i = 0; i < rows; i++)
  {
    int sum = 0;
    for (int j = 0; j < cols; j++)
    {
      sum += matrix[i, j];
    }
    result[i] = sum;
  }
  return result;
}

int MinIndex(int[] r)
{
  int minIndex = 0;
  for (int i = 0; i < r.Length; i++)
  {
    if (r[i] < r[minIndex])
    {
      minIndex = i;
    }
  }
  return minIndex;
}

var matrix = CreateMatrix(4, 4, 0, 10);
PrintMatrix(matrix);

int[] r = Sum(matrix);

int t = MinIndex(r);


System.Console.WriteLine($"Минимальная сумма в рядке {t}");