﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = vvediteChislo("Введите натуральное число: ");

NaturalNumber(N);

int vvediteChislo(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumber(int num)
{
  if (num == 0) return;
  // System.Console.WriteLine($"Начинаем функцию для num={num}");
  Console.Write($"{num} ");
  NaturalNumber(num - 1);
  // System.Console.WriteLine($"Заканчиваем функцию для num={num}");
}