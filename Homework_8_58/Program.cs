// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// создаёт и заполняет двумерный массив случайными числами от _min_ до _max_
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

// метод для умножения матриц
 int[,] MatrixMult(int[,] matrixA, int[,] matrixB)
{
  var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

  for (var i = 0; i < matrixA.GetLength(0); i++)
  {
    for (var j = 0; j < matrixB.GetLength(1); j++)
    {
      int sum = 0;
      for (var k = 0; k < matrixA.GetLength(1); k++)
      {
        sum += matrixA[i, k] * matrixB[k, j];
      }
      matrixC[i, j] = sum;
    }
  }

  return matrixC;
}

  int[,] a = CreateMatrix(2,3,0,10);
  PrintMatrix(a);
  Console.WriteLine();

  int[,] b = CreateMatrix(3,2,0,10);
  PrintMatrix(b);
  Console.WriteLine();

  if (a.GetLength(1) != b.GetLength(0))
  {
    Console.WriteLine("Умножение не возможно");
    return;
  }


  var result = MatrixMult(a, b);
  Console.WriteLine("Произведение матриц:");
  PrintMatrix(result);
