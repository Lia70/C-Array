// Задача №28 Напишите программу, которая на вход принимает число N 
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

void f(int n)
{
    int result = 1;
    for (int i = 2; i <= n; i ++)
    result *= i; // result = result * i
    Console.WriteLine(result);
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
f(n);
