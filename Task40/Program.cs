// Задача №40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// Теория о неравенстве треугольника: Каждая сторона треугольника
// меньше суммы двух других сторон.
// 5, 7, 8 -> yes
// 1, 1, 5 -> no
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (array[0] < array[1] + array[2]
   && array[1] < array[0] + array[2]
   && array[2] < array[1] + array[0])
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");