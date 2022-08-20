/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/

Console.Clear();
System.Console.WriteLine("Данная программа выводит в консоль последовательность натуральных элементов в заданном промежутке!");
System.Console.Write("Введите требуемый промежуток  \nввод через пробел: ");
string[] input1 = Console.ReadLine().Split();
int m = int.Parse(input1[0]);
int n = int.Parse(input1[1]);
GetSum(m, n);

void GetSum(int m, int n)
{
    if (m > n)
    {
        return;
    }
    System.Console.Write(m + " ");
    GetSum(++m, n);
}
