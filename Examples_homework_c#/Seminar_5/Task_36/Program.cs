using System;
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

System.Console.WriteLine("Создадим одномерный массив, заполненный случайными числами.");
System.Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] Array = new int[size];
Random rnd = new Random();

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = rnd.Next(-10 * size, 10 * size);
}
System.Console.WriteLine("Массив : {0} ", String.Join(" ", Array));
System.Console.WriteLine();
System.Console.Write("Элементы, стоящие на нечётных позициях: ");

int oddIndexSum = 0;

for (int i = 1; i < Array.Length; i++)
{
    if (i % 2 != 0)
    {
        oddIndexSum += Array[i];
        System.Console.Write(Array[i] + " ");
    }
}

System.Console.WriteLine("\n");
System.Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + oddIndexSum);