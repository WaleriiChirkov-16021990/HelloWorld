/*
Дополнительное задание

Напишите программу для вычисления площади круга, прямоугольника и треугольника. Ввод данных осуществляется в диалоговом режиме. На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить. На втором шаге пользователь вводит параметры, необходимые для рассчета. Затем, выводится результат.

** Дополнительное задание не является обязательным и на оценку не влияет! **
*/


using System;


Console.WriteLine("Enter name figure : ");
string? figure = Console.ReadLine();
figure = figure.ToLower();
double square = 0;

if (figure == "circle" | figure == "a circle" | figure == "circ" | figure == "окружность" | figure == "круг")
{
    Console.WriteLine("Enter diameter : ");
    int diameter = int.Parse(Console.ReadLine());
    square = 3.14 * diameter * diameter / 4;
    Console.WriteLine("Square a circle = " + Math.Round(square, 2));
}
else if (figure == "triangle" | figure == "треугольник")
{
    Console.WriteLine("Enter footing : ");
    int footing = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter height : ");
    int height = int.Parse(Console.ReadLine());
    square = footing * height / 2;
    Console.WriteLine("Square triangle = " + Math.Round(square, 2));
}
else if (figure == "rectangle" | figure == " прямоугольник")
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
    Console.WriteLine("Error! Unknown figure . Repeat the input! ");
}

