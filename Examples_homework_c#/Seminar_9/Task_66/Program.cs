/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.Clear();
System.Console.WriteLine("Данная программа считает сумму натуральных элементов в заданном промежутке!");
System.Console.Write("Введите требуемый промежуток  \nввод через пробел: ");
string[] input1 = Console.ReadLine().Split();
int m = int.Parse(input1[0]);
int n = int.Parse(input1[1]);
System.Console.WriteLine(GetSum(m, n));

int GetSum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + GetSum(++m, n);
}