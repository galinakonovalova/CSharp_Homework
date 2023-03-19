// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

fill(array);
print(array);

void fill(int[] array)
{
  Random ran = new Random();
  for (int i=0; i<array.Length;i++)
  {
    array[i] = ran.Next(0, 100);
  }
}

void print(int[] array)
{
  foreach (int v in array)
  {
    System.Console.Write($"{v} ");
  }
}