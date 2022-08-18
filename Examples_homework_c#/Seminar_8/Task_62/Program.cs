
/*
Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1  2  3  4
12 13 14 5
11 16 15 6
10 9  8  7
*/


using System;

Console.Clear();
System.Console.WriteLine("Данная программа заполняет спиралью массив 4х4 и любого другого размера!");
System.Console.Write("Введите количество строк и столбцов генерируемой целочисленной матрици \nввод через пробел: ");
string[] input1 = Console.ReadLine().Split();
int[,] rndArray1 = FillArray(input1);
System.Console.WriteLine("\nМатрица заполнена по спирали:");
PrintArray(rndArray1);

int[,] FillArray(string[] input)
{
    int[,] array = new int[int.Parse(input[0]), int.Parse(input[1])];
    int sizeItem = int.Parse(input[0]) * int.Parse(input[1]);

    for (int k = 0, item = 1; k <= int.Parse(input[0]) && item <= int.Parse(input[0]) * int.Parse(input[1]); k++)
    {

        for (int j = k, i = k; j < int.Parse(input[1]) - 1 - k; j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = item;
            }
            item++;
        }
        for (int j = int.Parse(input[1]) - 1 - k, i = k; i < int.Parse(input[0]) - 1 - k; i++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = item;
            }
            item++;
        }


        for (int i = int.Parse(input[0]) - 1 - k, j = int.Parse(input[1]) - 1 - k; j >= k; --j)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = item;
            }
            item++;
        }

        for (int i = int.Parse(input[0]) - 2 - k, j = k; i >= k + 1; --i)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = item;
            }
            item++;
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