// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

fill(array, -10, 10);
print(array);

int a = sumNeChetn(array);
Console.WriteLine($"Сумма чисел на нечетных позициях {a}");

int sumNeChetn(int[] array)
{
  int sum = 0;
  for (int i = 0; i<array.Length; i++)
  {
    if (i % 2 == 1)
    {
      sum += array[i];
    }
  }
  return sum;
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
}

