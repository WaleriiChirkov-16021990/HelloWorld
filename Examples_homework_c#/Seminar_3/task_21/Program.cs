
/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
using System;

Console.WriteLine("Введите координату A(X) ");
int AX = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату A(Y) ");
int AY = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату A(Z) ");
int AZ = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату B(X) ");
int BX = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату B(Y) ");
int BY = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату B(Z) ");
int BZ = int.Parse(Console.ReadLine());

Console.WriteLine("Длина отрезка AB = " + Math.Round(GetLength(AX, AY, AZ, BX, BY, BZ), 2));

double GetLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double Distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return Distance;
}
