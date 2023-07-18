// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int Promt(string message)
{
    System.Console.Write(message);  // Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);  // Приводим к числу
    return result;   //  Возвращаем результат
}
// Метод д/получения случайных значений массива:
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; // Объявляем массив 
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // Заполняем случайными цифрами 
        // из диапозона StartArr до EndArr
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); // Вывод значения массива
    }
    System.Console.Write($"{array[array.Length - 1]}"); // Вывод значения массива
    System.Console.WriteLine("]");
}
int Length = Promt("Длина массива: ");
int min = Promt("Начальное значение для диапозона случаного числа: ");
int max = Promt("Конечное значение для диапозона случаного числа: ");
int[] array = GenerateArray(Length, min, max); // Заполнение массива случайными числами
PrintArray(array);  // Вывод массива
