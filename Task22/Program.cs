// Задача №22 Напишите программу, которая на вход принимает число (N)
// и выдает таблицу квадратов чисел от 1 до N
// 5-> 1, 4, 9, 16, 25
// 2-> 1, 4
Console.Write("n= ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.WriteLine($"{i * i}  {Math.Pow(i, 2)}");

