using System.Xml;
/*
Дополнительное задание

Напишите программу для вычисления площади круга, прямоугольника и треугольника. Ввод данных осуществляется в диалоговом режиме. На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить. На втором шаге пользователь вводит параметры, необходимые для рассчета. Затем, выводится результат.

** Дополнительное задание не является обязательным и на оценку не влияет! **
*/


using System;


Console.WriteLine("Enter name figure : ");
string? figure = Console.ReadLine();
double square = 0;
// int diameter = 0;
// int footing = 0;
// int height = 0;
// int length = 0;
// int width = 0;

if (figure == "circle")
{
    Console.WriteLine("Enter diameter : ");
    int diameter = int.Parse(Console.ReadLine());
    square = 3.14 * diameter * diameter / 4;
    Console.WriteLine("Square a circle = " + Math.Round(square, 2));
}
else if (figure == "triangle")
{
    Console.WriteLine("Enter footing : ");
    int footing = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter height : ");
    int height = int.Parse(Console.ReadLine());
    square = footing * height / 2;
    Console.WriteLine("Square triangle = " + Math.Round(square, 2));
}
else if (figure == "rectangle")
{
    Console.WriteLine("Enter length : ");
    int length = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter width : ");
    int width = int.Parse(Console.ReadLine());
    square = length * width;
    Console.WriteLine("Square rectangle = " + square);
}
else
{
    Console.WriteLine("Error! Repeat the input! ");
}

