// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix(int rows, int columns, int deep, int min, int max)
{
  var rnd = new Random();
  var matrix = new int[rows, columns, deep];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int d = 0; d < matrix.GetLength(2); d++)
      {
        matrix[i, j,d] = rnd.Next(min, max + 1);
      }
    }
  }
  return matrix;
}

//Печатает трехмерный массив на экран
void PrintMatrix(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int d = 0; d < matrix.GetLength(2); d++)
      {
        Console.Write($"{matrix[i, j,d],4} ({i},{j},{d})");
      }
    }
    Console.WriteLine("|");
  }
}


int[,,] matrix = CreateMatrix(2, 2, 2, 10, 99);
PrintMatrix(matrix);