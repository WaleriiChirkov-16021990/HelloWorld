
using System.Linq.Expressions;
using System;
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3
*/

System.Console.WriteLine("Данная программа сосчитает, сколько чисел больше 0 ввёл пользователь.");

while (true)
{
    int m = 0;
    int count = 0;
    try
    {
        System.Console.WriteLine("Сколько целых чисел вы собираетесь вводить ? Ответьте целым числом !");
        m = int.Parse(Console.ReadLine());
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("Вы ввели не целое число или неизвестный символ, следуйте указаниям на экране!\n Начнем сначала!?");
        Console.ReadLine();
        continue;
    }

    int[] numbers = new int[m];
    for (int i = 1; i <= m; i++)
    {
        System.Console.Write("Введите " + i + " целое число: ");
        System.Console.WriteLine();
        numbers[i - 1] = int.Parse(Console.ReadLine());
        if (numbers[i - 1] > 0)
        {
            count++;
        }
    }

    System.Console.WriteLine("Вы ввели следующие числа : {0} ", String.Join(" ", numbers));
    System.Console.WriteLine($"Из них чисел больше 0: " + count + " ! ");


    System.Console.WriteLine("Для завершения программы нажмите ctrl + c \n Для продолжения, нажмите любую кнопку!");
    Console.ReadLine();

}