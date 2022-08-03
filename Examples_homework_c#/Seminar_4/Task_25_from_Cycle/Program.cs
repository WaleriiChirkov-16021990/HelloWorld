using System;
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Не совсем понял куда конкретно применить цикл, потому попробую везде.
*/


Console.WriteLine("Программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
int[] Array = new int[2];
for (int i = 1; i < 3; i++)
{
    Console.WriteLine("Введите " + i + "-е число");
    Array[i - 1] = int.Parse(Console.ReadLine());
}
int z = 0;
int result = 1;
while (z < Array[1])
{
    result = result * Array[0];
    z++;
}
Console.WriteLine(Array[0] + " в степени " + Array[1] + " = " + result);
