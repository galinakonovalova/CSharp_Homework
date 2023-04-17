// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine($"Введите первое положительное число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите второе положительное число");
int n = Convert.ToInt32(Console.ReadLine());

int sum = Sum(m, n);
Console.WriteLine($"Сумма {sum}");

int Sum(int num, int end)
{
  if (num == end)
  {
    return num;
  }
  return num + Sum(num + 1, end);
}



