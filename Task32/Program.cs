﻿// Задача №32: Напишите программу замена элементов массива: положительные массивы
// замените на соответствующие отрицательные, и наоборот
// [-4, -8, 8, 2]-> [4, 8 ,-8, -2]

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);  // [-9;9]
}
void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *=(-1);
}
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray (array);
Console.WriteLine($"[{string.Join(", ", array)}]");

