﻿// Задача №42: Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
string res = String.Empty;
while (n > 0)
{
    res = Convert.ToString(n % 2) + res;
    n /= 2; // n = n / 2
}
Console.WriteLine(res);
