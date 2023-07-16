// Задача №20 Напишите программу, которая на вход принимает координаты двух точек
// и находит расстояние между ними в 2D пространстве
// A(3,6); B(2,1)->5,09
// A(7,-5); B(1,-1)->7,21
Console.Write("X1 = ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X2 = ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2)),2));
