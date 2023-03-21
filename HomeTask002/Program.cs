// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void RandomInArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-50, 51);
}

void ResultIndPrint(int[] array)
{
  int count = 0;
  for (int i = 1; i < array.Length; i += 2)
    count = count + array[i];
  Console.WriteLine($"Массив [{string.Join(", ", array)}], сумма чисел стоящих на нечётных позициях = ({(count)}).");
}

System.Console.Clear();
System.Console.Write("Укажите размер массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
RandomInArray(array); // Заполняет массив
ResultIndPrint(array); // Проверяет массив и выдаёт результат