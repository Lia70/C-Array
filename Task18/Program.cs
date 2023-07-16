// Задача №18 Напишите программу, которая по заданному номеру четверти показывает
// диапазон возможных координат точек в этой четверти (X , Y)

Console.Write("Введите номер четверти: ");
int n= Convert.ToInt32(Console.ReadLine());
while ( n < 1 || n > 4)
{
    Console.Write("Введите номе четверти: ");
    n= Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.Write("X > 0 & Y > 0");
else if (n == 2)
    Console.Write("X < 0 & Y > 0");
else if (n == 3)
    Console.Write("X < 0 & Y < 0");
else if (n == 4)
    Console.Write("X > 0 & Y < 0");

Console.WriteLine("");
