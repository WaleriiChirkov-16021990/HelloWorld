using System;
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
System.Console.WriteLine("программа выводит значение элемента массива по запрошенным координатам!");
int[,] numbers = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
string[] input = null;

try
{
    System.Console.Write("Введите коорднаты элемента в массиве через пробел: ");
    input = Console.ReadLine().Split();

}
catch (System.Exception)
{
    throw;
}

System.Console.WriteLine("Массив элементов: ");
PrintArray(numbers);

if (IsFindItem(input, numbers))
{
    System.Console.WriteLine("По данным координатам лежит элемент= " + GetItemArray(input, numbers));
}
else
{
    System.Console.WriteLine("Такого числа нет в массиве!");
}


int GetItemArray(string[] arrayCoordinates, int[,] arrayNumbers)
{
    int rows = int.Parse(arrayCoordinates[0]);
    int columns = int.Parse(arrayCoordinates[1]);
    int item = arrayNumbers[rows, columns];
    return item;
}

bool IsFindItem(string[] arrayCoordinates, int[,] arrayNumbers)
{
    int rows = int.Parse(arrayCoordinates[0]);
    int columns = int.Parse(arrayCoordinates[1]);
    if (rows < arrayNumbers.GetLength(0)
       && columns < arrayNumbers.GetLength(1))
    {
        return true;
    }
    return false;
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