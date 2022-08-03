using System;
/*
Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
*/

Console.WriteLine("Программа задаёт массив из 8 элементов и выводит их на экран.");

Console.WriteLine("Следуйте указаниям в консоли!");
int[] ArrayElement = new int[8];

for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Введите элемент c индексом " + i);
    ArrayElement[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Ввод завершён !");

Console.WriteLine(" Массив: {0}", String.Join(" ", ArrayElement));