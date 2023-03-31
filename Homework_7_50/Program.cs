//  Задача 50. Напишите программу, которая на вход принимает 
//  позиции элемента в двумерном массиве, и возвращает значение
//  этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

int vvediteChislo(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

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

//создаём матрицу
int[,] matrix = CreateMatrix(3, 5, -10, 20);

// печатает матрицу
PrintMatrix(matrix);

//просим ввести i
int i = vvediteChislo("Введите ряд: ");

//просим ввести j
int j = vvediteChislo("Введите столбец: " );

//пишем на экран matrix[i,j]
if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
{
  Console.WriteLine(matrix[i,j]);
}
else
{
  Console.WriteLine("такого числа в массиве нет");
}
