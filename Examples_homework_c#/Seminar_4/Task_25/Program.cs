using System;
/*
Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
*/

Console.WriteLine("Программа принимает на вход два числа и возводит число A в натуральную степень B");
Console.Write("Введите число : ");
double number = double.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = int.Parse(Console.ReadLine());

if (degree >= 1)
{
    Console.WriteLine(" Число " + number + " в степени " + degree + " = " + Math.Round(Math.Pow(number, degree), 3));
}
else
{
    Console.Write("Недопустимое значение! Повторно запустите программу и введите натуральную степень!! (1,2,3,4....) ");
}