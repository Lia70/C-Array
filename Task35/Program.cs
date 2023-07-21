// Задача №35: Задайте одномерный массив из 8 случайных чисел. Найдите кол-во
// элементов массива, значения кот-х лежат в отрезке [10,99].
// Пример для массива из 5, а не из 123 элементов. В своем решении сделайте для 8
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);  // [-9;9]
}
int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= 10 && array[i] <= 99) 
         count++;
    return count;     
}
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));