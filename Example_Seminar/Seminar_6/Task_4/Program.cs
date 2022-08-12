using System;
/*
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

int[] array = { 1, 2, 3, 4, 5 };
int[] copyArray = GetCopy(array);
System.Console.Write("Исходный массив : ");
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}

System.Console.WriteLine("\n Копия исходного массива создана: {0} ", String.Join(" ", GetCopy(array)));
System.Console.WriteLine();




int[] GetCopy(int[] array)
{
    int[] copy = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}
