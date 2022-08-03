using System;

/*
Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
*/

Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе.");
Console.Write(" Введите положительное целое число, которое содержит 2 и более знаков :");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма цифр данного числа = " + GetSumItem(number));

int GetSumItem(int number)
{
    int Sum = 0;
    while (number > 0)
    {
        Sum = Sum + number % 10;
        number = number / 10;
    }
    return Sum;

}
