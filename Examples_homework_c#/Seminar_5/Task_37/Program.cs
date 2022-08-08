using System;
/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21
*/

int[] array = { 1, 2, 3, 4, 5 };
System.Console.WriteLine("Массив произведений зеркальных элементов: {0} ", String.Join(" ", GetMultiplyItemArray(array)));
int[] array2 = { 6, 7, 3, 6 };
System.Console.WriteLine("Массив произведений зеркальных элементов: {0} ", String.Join(" ", GetMultiplyItemArray(array2)));

int[] GetMultiplyItemArray(int[] array)
{
    int size = 0;
    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
    }
    else
    {
        size = array.Length / 2 + 1;
    }
    int[] MultiplyArray = new int[size];

    int i = 0;
    while (i < array.Length - 1 - i)
    {
        MultiplyArray[i] = array[i] * array[array.Length - i - 1];
        i++;
    }
    if (array.Length % 2 != 0)
    {
        MultiplyArray[size - 1] = array[array.Length / 2];
    }
    return MultiplyArray;
}