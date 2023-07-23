// Задача №45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования

Console.Write("Введите число: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[] array2 = new int[array.Length];

for (int i = 0; i < array2.Length; i++)
    array2[i] = array[i];
Console.WriteLine($"[{string.Join(", ", array2)}]");