﻿// Задача №37: Найдите произведение пар чисел  одномерном массиве.
// Парой считаем первый и последний, второй и предпоследний элемент и т.д.
// Результат запишите в новом массиве.
// [1, 2, 3, 4, 5] -> 5, 8, 3
// [6, 7, 3, 6] -> 36, 21
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(0, 10);  // [-9;9]
}
void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
        Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
    if (array.Length % 2 == 1)
        Console.Write($"{array[array.Length / 2]} ");
    // i = 0...1
    // i = 0
    // 0 * 5 - 1 - 0 = 4
    // i = 1
    // 1 * 5 - 1 - 1 = 3
    // i = 2
    // 2 * 5 - 1 - 2 = 2
    // i = 3
    // 3 * 5 - 1 - 3 = 1
}
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
