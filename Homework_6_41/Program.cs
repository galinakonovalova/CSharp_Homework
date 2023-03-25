// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


// Просим от пользователя ввести число M
int M = vvediteChislo("Введите M: ");

// создаём массив размером М
int[] array = new int[M];//={}

// в цикле i=0..М просим пользователя ввести число и пишем его в массив по индексу i
vvediteArray(array);

// бежим по массиву и считаем count++ ТОЛЬКО если значение элемента >0
int count = 0;
for (int i = 0; i<array.Length; i++)
  {
    if (array[i] > 0)
    {
      count++;
    }
  }

// выводим count
Console.WriteLine($"Положительных чисел {count}");


int vvediteChislo(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

// в цикле i=0..М просим пользователя ввести число и пишем его в массив по индексу i
void vvediteArray(int[] array)
{
  for (int i = 0; i<array.Length; i++)
  {
    array[i] = vvediteChislo("Введите число: ");
  }
}