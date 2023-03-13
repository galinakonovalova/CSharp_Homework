// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 5  && day <=7) //будет выходной 
{
  System.Console.WriteLine("Выходной");
}
else if (day <=5)
{
  System.Console.WriteLine("Нет");
}
else  
{
  System.Console.WriteLine("Не день недели");
}
