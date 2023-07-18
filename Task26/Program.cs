// Задача №26 Напишите программу, которая на вход принимает число
// и выдает количество цифр в этом числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int f(int n)
{
    int count = 0;
    while (n > 0)
    {
        n /= 10;     // n = n / 10
        count++;
    }
    return count;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
