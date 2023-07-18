// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/* Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = 1;
if (B < 1)
    Console.Write("Число B должно быть натуральным / n");
else
{
    while (B != 0)
    {
        C = C * A;
        B = B - 1;
    }
    Console.Write($"Число A в натуральной степени B равно: {C}");
} */
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int C = A;
for ( int i = 1; i < B; i ++)
{
    C = C * A;
}
Console.WriteLine($"Число A в натуральной степени B равно: {C}");