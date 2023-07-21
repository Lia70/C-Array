// Задача №33: Задайте массив. Напишите программу, которая определяет
// присутствует ли заданное число в массиве
// 4; массив [6,7,19,345,-3] -> нет
// -3; массив [6,7,19,345,-3] -> да

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 5);  // [-9;9]
}
string ReleaseArray(int[] array, int x)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == x) 
            return "yes";
    return "no";
}
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для поиска: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array, x));
