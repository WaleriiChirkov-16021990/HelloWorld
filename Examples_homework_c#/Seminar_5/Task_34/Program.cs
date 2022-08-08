using System;
/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] RandomArray = new int[30];
Random rnd = new Random();

for (int i = 0; i < RandomArray.Length; i++)
{
    RandomArray[i] = rnd.Next(100, 1000);
}
System.Console.WriteLine("Массив : {0} ", String.Join(" ", RandomArray));

int count = 0;

for (int i = 0; i < RandomArray.Length; i++)
{
    if (RandomArray[i] % 2 == 0)
    {
        count++;
    }
}

System.Console.WriteLine();
System.Console.WriteLine("В данном массиве четных чисел :" + count);
