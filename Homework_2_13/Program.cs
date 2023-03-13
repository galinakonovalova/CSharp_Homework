// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  n = ukorachivaemDo3Cyfr(n);
  // while (n >= 1000)
  // {
  //   n = n / 10;
  // }
  n = n % 10;
  Console.WriteLine($"Третья цифра {n}");
}

//---------
int ukorachivaemDo3Cyfr(int a)
{
  while (a >= 1000)
  {
    a = a / 10;
  }
  return a;
}