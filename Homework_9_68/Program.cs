// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine($"Введите первое положительное число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите второе положительное число");
int n = Convert.ToInt32(Console.ReadLine());

int sum = Akkerman(m, n);
Console.WriteLine($"Функция Аккермана {sum}");

int Akkerman(int n, int m)
{
  while (n != 0)
  {
    if (m == 0)
      m = 1; 
    else
      m = Akkerman(n, m - 1);
    n = n - 1;
  }
  return m + 1;
}

