﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число:");
int x = Convert.ToInt32(Console.ReadLine());

int a1 = x % 10;
int a2 = x / 10 % 10;
int a3 = x / 100 % 10;
int a4 = x / 1000 % 10;
int a5 = x / 10000 % 10;

int x2 = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;

Console.Write(x == x2 ? "Да" : "Нет");
 