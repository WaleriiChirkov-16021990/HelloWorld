using System;
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

--
*/


System.Console.WriteLine("В данной программе мы найдем разницу между и максимальным элементом массива вещественных чисел.");
System.Console.Write("Задайте размер массива: ");
int size = int.Parse(System.Console.ReadLine());
double[] Array = new double[size];
Random rnd = new Random();

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = Math.Round(rnd.NextDouble() * size, 2);
}

System.Console.WriteLine("Созданный массив : {0} ", String.Join(" ", Array));
SelectionMaxMinSortItemArray(Array);
System.Console.WriteLine("Отсортированный массив : {0} ", String.Join(" ", Array));
System.Console.WriteLine("\n Максимальный элемент массива : " + Array[0] + " Минимальный элемент массива: " + Array[Array.Length - 1]);
System.Console.Write(" Разница между максимальныи и минимальным элементами массива = ");
System.Console.Write(Math.Round(Array[0] - Array[Array.Length - 1], 2));
System.Console.WriteLine();



void SelectionMaxMinSortItemArray(double[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;

        }
        Swap(ref array[maxPosition], ref array[i]);
    }

}

void Swap(ref double leftItem, ref double rightItem)
{
    double temp = leftItem;
    leftItem = rightItem;
    rightItem = temp;
}