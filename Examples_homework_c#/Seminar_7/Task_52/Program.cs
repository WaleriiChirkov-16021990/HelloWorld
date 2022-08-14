using System;
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

System.Console.WriteLine("Данная программа заполняет по указанному размеру двумерный массив \nи находит среднее арифметическое элементов в каждом столбце!");
System.Console.Write("Укажите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int[,] Arr = GetRandomArray(input);
PrintArray(Arr);
Console.WriteLine("Среднее арифметическое элементов по столбцам  \n{0} ", String.Join("\t", AverageValueColumns(Arr)));


int[,] GetRandomArray(string[] input)
{
    int rows = int.Parse(input[0]);
    int columns = int.Parse(input[1]);
    Random rnd = new Random();
    int[,] random = new int[rows, columns];
    for (int i = 0; i < random.GetLength(0); i++)
    {
        for (int j = 0; j < random.GetLength(1); j++)
        {
            random[i, j] = rnd.Next(1, 15);
        }

    }
    return random;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine("\n");
    }
}

double[] AverageValueColumns(int[,] array)
{
    double[] averageValue = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double Sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Sum += Convert.ToDouble(array[i, j]);
        }
        averageValue[j] = Math.Round(Sum / array.GetLength(0), 1);
    }
    return averageValue;
}