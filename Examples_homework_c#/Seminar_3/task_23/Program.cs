
/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

using System;

Console.WriteLine("Введите целое положительное число : ");
int num = int.Parse(Console.ReadLine());

for (int countNumber = 1; countNumber <= num; countNumber++)
{
    long result = countNumber * countNumber * countNumber;

    Console.Write(" " + result);
}

