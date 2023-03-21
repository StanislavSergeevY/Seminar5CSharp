// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void RandomInArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
}

void ResultIndPrint(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if(array[i] % 2 == 0)
  count++;
}
Console.WriteLine($"Массив [{string.Join(", ", array)}], из них чётные - ({(count)}).");
}

Console.Clear();
System.Console.Write("Укажите размер массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
RandomInArray(array); // Заполняет массив
ResultIndPrint(array); // Проверяет массив и выдаёт результат