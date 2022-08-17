/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using System;
System.Console.WriteLine("Данная программа суммирует элементы каждой строки двумерного массива \nи выдаёт номер строки с найменьшей суммой элементов!");
System.Console.Write("Введите количество строк и столбцов генерируемого прямоугольного целочисленного массива \nчерез пробел: ");
string[] input = Console.ReadLine().Split();
int[,] rndArray = GetArray(input);
PrintArray(rndArray);
int[] createSumRowsARRAY = SumRowsArray(rndArray);
System.Console.WriteLine("Строка ниже не обязательна, она создана автоматически, от чуства заботы о ревьюере, \nкоторый проверяет данную работу и не хочет считать сумму строк самостоятельно.");
System.Console.WriteLine("Суммы строк представлены построчно, начиная от 1 строки с индексом 0 : \n{0} ", String.Join("\n", createSumRowsARRAY));

Console.WriteLine($" Строка {GetNumberRowsMinSumItem(rndArray) + 1} с индексом {GetNumberRowsMinSumItem(rndArray)} имеет минимальную сумму элементов! ");
System.Console.WriteLine("И (на всякий случай): ");
Console.WriteLine($" Строка {GetNumberRowsMaxSumItem(rndArray) + 1} с индексом {GetNumberRowsMaxSumItem(rndArray)} имеет максимальную сумму элементов! ");
System.Console.WriteLine();

int[,] GetArray(string[] input)
{
    int[,] array = new int[int.Parse(input[0]), int.Parse(input[1])];
    Random rnd = new Random();
    for (int i = 0; i < int.Parse(input[0]); i++)
    {
        for (int j = 0; j < int.Parse(input[1]); j++)
        {
            array[i, j] = rnd.Next(0, 32);
        }
    }
    return array;
}

int[] SumRowsArray(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Sum += array[i, j];
        }
        sumRows[i] = Sum;
    }
    return sumRows;
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

int GetNumberRowsMinSumItem(int[,] array)
{
    int[] sumRows = SumRowsArray(array);
    int minIndex = 0;
    for (int i = 0; i < sumRows.Length; i++)
    {
        if (sumRows[i] < sumRows[minIndex])
        {
            minIndex = i;
        }
    }
    return minIndex;
}
int GetNumberRowsMaxSumItem(int[,] array)
{
    int[] sumRows = SumRowsArray(array);
    int maxIndex = 0;
    for (int i = 0; i < sumRows.Length; i++)
    {
        if (sumRows[i] > sumRows[maxIndex])
        {
            maxIndex = i;
        }
    }
    return maxIndex;
}