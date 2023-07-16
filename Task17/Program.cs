// Задача №17 Напишите программу, которая на вход принимает координаты точки (X, Y),
// причем X ≠ 0, Y ≠ 0 и выдает номер четверти плоскости, в которой находится эта точка
Console.Clear();
Console.Write("X = ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int Y = Convert.ToInt32(Console.ReadLine());
if (X > 0 & Y > 0)
    Console.Write("I");
else if (X < 0 & Y > 0)
    Console.Write("II");
else if (X < 0 & Y < 0)
    Console.Write("III");
else if (X > 0 & Y < 0)
    Console.Write("IV");

Console.WriteLine("");