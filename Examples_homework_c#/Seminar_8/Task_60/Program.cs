/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/

using System;
System.Console.WriteLine("Данная программа формирует трехмерный массив! и выводит его на экран построчно. \nРазмер массива вводит пользователь!");
System.Console.Write("Введите количество строк,столбцов и размер пространства генерируемого целочисленного массива \nчерез пробел: ");
string[] input = Console.ReadLine().Split();
int[,,] rnd3DArray = GetArray(input);
PrintArray(rnd3DArray);


int[,,] GetArray(string[] input)
{
    int[,,] array = new int[int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2])];
    int item = 10;
    for (int x = 0; x < int.Parse(input[0]); x++)
    {
        for (int y = 0; y < int.Parse(input[1]); y++)
        {
            for (int z = 0; z < int.Parse(input[2]); z++)
            {
                array[x, y, z] = item;
                item++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        System.Console.WriteLine($"Пространство {k} : ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write($"{array[i, j, k]} : [{i},{j},{k}]" + "\t");
            }
            System.Console.WriteLine();
        }
    }
}
