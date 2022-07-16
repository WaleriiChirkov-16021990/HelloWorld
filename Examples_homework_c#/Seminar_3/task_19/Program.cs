

using System;
/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine(" Enter number : ");
int number = int.Parse(Console.ReadLine());

if (number > 9999 & number < 100000)
{
    if (IsEqually(number) == true)
    {
        Console.WriteLine(string.Join(" ", IsEqually(number), " Число является палиндромом ! "));
    }
    else
    {
        Console.WriteLine(string.Join(" ", IsEqually(number), "Число не является полиндромом ! "));
    }
}
else
{
    Console.WriteLine("ERROR! Программа принимает на ввод только 5-ти значное число 😢! Повторите Ввод ! ");
}





bool IsEqually(int num)
{
    int[] Array = new int[5];
    int index = 0;
    while (index < 5)
    {
        Array[index] = num % 10;
        num /= 10;
        index++;
    }


    int item = 0;

    if (Array[item] == Array[index - item - 1])
    {
        while (item <= index - item - 1)
        {



            item++;
        }
        return true;
    }


    return false;
}


