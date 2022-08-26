// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// Например: 
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
 
public class ycheba {
 
    static void Summa123(int[] arr, int n)
    {
        int e = 0;
        int o = 0;
 
        for (int i = 0; i < n; i++) {
            if (i % 2 == 0)
                e += arr[i];
            else
                o += arr[i];
        }
        Console.WriteLine("Even index positions sum "
                          + e);
        Console.WriteLine("Odd index positions sum " + o);
    }
 
    static public void Main()
    {
 
        int[] arr = {3, 7, 23, 12};
        int n = arr.Length;
 
        Summa123(arr, n);
    }
}
 