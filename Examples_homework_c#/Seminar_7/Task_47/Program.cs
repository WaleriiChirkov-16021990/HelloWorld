using System;
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

System.Console.WriteLine("Введите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int rows = int.Parse(input[0]);
int columns = int.Parse(input[1]);
PrintArray(GetArray(rows, columns));


double[,] GetArray(int rows, int columns)
{
    double[,] numbers = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.NextDouble() * 100 - 50;
        }

    }
    return numbers;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(array[i, j], 1) + "\t");
        }
        System.Console.WriteLine();
    }
}