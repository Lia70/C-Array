// Задача №24 Напишите программу, которая принимает на вход
// число (A) и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write("Введите число: ");
// Double n = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine((1 + n) / 2 * n);

double f(double n)
{
    return (1 + n) / 2 * n;
}
Console.Write("Введите число: ");
Double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(f(n));

