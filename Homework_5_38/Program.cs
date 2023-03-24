// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = new double[10];

fillDouble(array);
printDouble(array);



void fillDouble(double[] array)
{
  Random ran = new Random();
  for (int i=0; i<array.Length;i++)
  {
    array[i] = ran.NextDouble();
  }
}

void printDouble(double[] array)
{
  foreach (double v in array)
  {
    System.Console.Write($"{v} ");
  }
}


