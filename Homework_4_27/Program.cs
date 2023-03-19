// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Write("Введите число:");
int one = Convert.ToInt32(Console.ReadLine()); 

int result=mneSum(one);
Console.WriteLine(result);

int mneSum(int x)
{
  int sum=0;
  
  while(x > 0) //условие выхода
  {
    int digit = x % 10;
    sum += digit;

    x=x/10;//шаг
  } 
  return sum; 
}

