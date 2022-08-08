using System;
/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21
*/

int[] array = { 1, 2, 3, 4, 5 };
MultiplyItemArray(array);
int[] array2 = { 6, 7, 3, 6 };
MultiplyItemArray(array2);

void MultiplyItemArray(int[] array)
{
    int multiplication = 0;
    int i = 0;
    while (i < array.Length - 1 - i)
    {
        multiplication = array[i] * array[array.Length - i - 1];
        System.Console.Write(multiplication + " ");
        multiplication = 0;
        i++;
    }
    if (array.Length % 2 != 0)
    {
        System.Console.WriteLine(array[array.Length / 2]);
    }
}