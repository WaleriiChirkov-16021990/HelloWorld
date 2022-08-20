
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/


using System;

Console.Clear();
System.Console.WriteLine("Данная программа считает произведение двух матриц!");
System.Console.Write("Введите количество строк и столбцов генерируемых прямоугольных целочисленных матриц \nввод через пробел: ");
string[] input1 = Console.ReadLine().Split();
int[,] rndArray1 = GetArray(input1);
System.Console.WriteLine("\nМатрица 1");
PrintArray(rndArray1);
int[,] rndArray2 = GetArray(input1);

System.Console.WriteLine("\nМатрица 2: Перезагрузка");
PrintArray(rndArray2);
int[,] multiply = MultiplyArray(rndArray1, rndArray2);
Console.WriteLine("\nРезультат произведения этих матриц: ");
PrintArray(multiply);


int[,] GetArray(string[] input)
{
    int[,] array = new int[int.Parse(input[0]), int.Parse(input[1])];
    Random rnd = new Random();
    for (int i = 0; i < int.Parse(input[0]); i++)
    {
        for (int j = 0; j < int.Parse(input[1]); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplyArray(int[,] array1, int[,] array2)
{
    if (array1.GetLength(0) != array2.GetLength(1))
    {
        throw new Exception(" Матрицы нельзя перемножать!");
    }
    int[,] multiplyArray = new int[array1.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(0); k++)
            {
                multiplyArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return multiplyArray;
}
