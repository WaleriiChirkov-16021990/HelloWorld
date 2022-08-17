/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/
using System;
System.Console.WriteLine("Данная программа упорядочит по убыванию элементы каждой строки двумерного массива!");
System.Console.Write("Введите количество строк и столбцов генерируемого целочисленного массива через пробел: ");
string[] input = Console.ReadLine().Split();
int[,] array = new int[int.Parse(input[0]), int.Parse(input[1])];
Random rnd = new Random();
for (int i = 0; i < int.Parse(input[0]); i++)
{
    for (int j = 0; j < int.Parse(input[1]); j++)
    {
        array[i, j] = rnd.Next(0, 32);
    }
}

PrintArray(array);
System.Console.WriteLine("Отсортируем этот массив построчно!? \nPress Enter");
Console.ReadKey();
SortedRowsItemMaxMin(array);
System.Console.WriteLine("Получили отсортированный массив!");
PrintArray(array);
System.Console.WriteLine("Желаете продолжить? =)");
Console.ReadKey();
SortedRowsItemMinMax(array);
System.Console.WriteLine("А теперь сортировка массива как в примере:");
PrintArray(array);


void PrintArray(int[,] array)
{
    for (int i = 0; i < int.Parse(input[0]); i++)
    {
        for (int j = 0; j < int.Parse(input[1]); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void SortedRowsItemMaxMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {

            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition])
                {
                    maxPosition = k;
                }
            }
            Swap(ref array[i, j], ref array[i, maxPosition]);
        }
    }
}

void SortedRowsItemMinMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] < array[i, minPosition])
                {
                    minPosition = k;
                }
            }
            Swap(ref array[i, j], ref array[i, minPosition]);
        }
    }
}

void Swap(ref int leftItem, ref int richtItem)
{
    int tempPosition = richtItem;
    richtItem = leftItem;
    leftItem = tempPosition;
}


