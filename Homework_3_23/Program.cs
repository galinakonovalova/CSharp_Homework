// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine()); 

int count = 1;
while (count>=n)
{
  int cub = count*count*count;
  Console.WriteLine($"{count} | {cub}");
  count++;
}

















































// for (int count=1;count<=n;count++)
// {
//   int cub = count*count*count;
//   Console.WriteLine($"{count} | {cub}");
// }

// int count = 1;
// while( count <= n)
// {
//   int cub = count*count*count;
//   Console.WriteLine($"{count} | {cub}");
//   count++;
// }


