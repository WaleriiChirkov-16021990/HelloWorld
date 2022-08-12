/*
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
*/

bool isTriangle(int a, int b, int c)
{
    if (a + b > c && c + b > a && a + c > b)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.WriteLine("Введите 1 число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите 2 число");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите 3 число");
int c = int.Parse(Console.ReadLine());

if (isTriangle(a, b, c))
{
    System.Console.WriteLine("Треугольник реален");
}
else
{
    System.Console.WriteLine("Треугольник нереален");
}

