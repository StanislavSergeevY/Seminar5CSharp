// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int IsNumers(string n)
{
  bool numers = int.TryParse(n, out int volue);
  while(numers == false)
  {
    Console.Write("Вы ввели не число, повторите попытку: ");
    numers = int.TryParse(Console.ReadLine(), out volue);
  }
  return volue;
}

void RandomInArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-50, 51);
}

void PrintArray(double[] array)
{
  Console.Write($"Массив [{string.Join(", ", array)}] ");
}

void Procedure(double[] array)
{
  double result = 0;
  double max = array[0], min = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] > max)
      max = array[i];
    else if (array[i] < min)
      min = array[i];
  }
  if (max < 0 && 0 > min)
    Console.WriteLine($"Разница максимального и минимального значения = {result = min - max}.");
  else if (max > 0 && 0 > min)
    Console.WriteLine($"Разница максимального и минимального значения = {result = max + min}.");
  else
    Console.WriteLine($"Разница максимального и минимального значения = {result = max - min}.");
  
  
  Console.WriteLine($"Макс = {max}");
  Console.WriteLine($"Мини = {min}");
}

Console.Clear();
Console.Write("Укажите размер массива: ");
double[] array = new double[(IsNumers(Console.ReadLine()))]; // +Проверка ввода числа
RandomInArray(array); // Заполняет массив
PrintArray(array); // Печать массива
Procedure(array); // Выполняет условия задачи и выдаёт результат