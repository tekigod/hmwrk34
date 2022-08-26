// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// Например: 
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Количество чисел: ");
double v = Convert.ToDouble(Console.ReadLine());
int r = Convert.ToInt32(v);
int[] a = new int[r];
int max = 0;
int min = 0;
 
for (int i = 0; i < r; i++)
{
Console.Write("Число {0}: ", i + 1);
 
a[i] = Convert.ToInt32(Console.ReadLine());
 
}
min = a[0];
max = a[0];
for (int i = 1; i < r; i++)
{
if (a[i] < min)
min = a[i];
if (a[i] > max)
max = a[i];
}
int d = max - min;
 
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
Console.WriteLine("Разность: "+ d);
 
Console.ReadKey();