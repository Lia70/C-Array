// Задача №31:и Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму полож-х и отриц-х элементов массива.
// Н, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма полож-х чисел равна 29,
// сумма отриц-х чисел равна -20

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);  // [-9;9]
}
void ReleaseArray(int[] array)
{
    int sum_ot = 0;
    int sum_pol = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sum_pol += array[i];
        else
            sum_ot += array[i];
    Console.WriteLine($"Сумма отриц-х = {sum_ot}, сумма полож-х = {sum_pol}");
}
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);