// Задача №30 Напишите программу, которая выводит массив из 8 элементов
// заполненный 0 и 1 в случайном порядке

int[] array = new int[8];
for (int i = 0; i < array.Length; i ++)
     array [i] = new Random().Next (0, 2); // [0;1]
Console.WriteLine($"[{string.Join(", ", array)}]");

