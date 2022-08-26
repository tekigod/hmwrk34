// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая 
// 1. покажет количество чётных чисел в массиве.
// Например:
// [345, 897, 568, 234] -> 2

int s, chet, nechet;
int[] arr;
 
Console.Write("Введите размер массива: ");
s = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Введите числа: ", s);
arr = new int[s];
for (int i = 0; i < s; i++)
{
    Console.Write("Число {0}: ", i+1);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
            
chet = 0;
nechet = 0;
for (int i = 0; i < s; i++)
{
    if (arr[i] % 2 == 0)
    {
        chet++;
    }
    else
    {
        nechet++;
    }
}
 
Console.Write("Количество четных чисел: {0}\n", chet);
Console.Write("Количество нечетных чисел: {0}", nechet);
 
Console.ReadLine();