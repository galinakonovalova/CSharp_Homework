// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[34];


fill(array, 100, 999);
print(array);

int a = countChetn(array);
Console.WriteLine($"Количество четных чисел {a}");

int countChetn(int[] array)
{
  int count = 0;
  // foreach (int v in array)
  for (int i = 0; i<array.Length; i++)
  {
    // if (v % 2 == 0)
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

void fill(int[] array, int min, int max)
{
  Random ran = new Random();
  for (int i=0; i<array.Length;i++)
  {
    array[i] = ran.Next(min, max + 1);
  }
}

void print(int[] array)
{
  foreach (int v in array)
  {
    System.Console.Write($"{v} ");
  }
  System.Console.WriteLine();
}
