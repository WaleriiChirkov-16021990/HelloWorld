using System;
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
Console.Clear();
System.Console.WriteLine("Эта программа найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;\n Для практики отработаю двумерный массив! Но это было не обязательно.");

double[,] Coordinates = new double[2, 2];
System.Console.Write("Введите k1: ");
Coordinates[0, 0] = double.Parse(System.Console.ReadLine());

System.Console.Write("Введите b1: ");
Coordinates[0, 1] = double.Parse(System.Console.ReadLine());

System.Console.Write("Введите k2: ");
Coordinates[1, 0] = double.Parse(System.Console.ReadLine());

System.Console.Write("Введите b2: ");
Coordinates[1, 1] = double.Parse(System.Console.ReadLine());

System.Console.WriteLine("двумерный массив констант: ");
Print2DArray(Coordinates);
if (IsIntersection(Coordinates))
{
    System.Console.WriteLine("Массив координат пересечения : {0} ", String.Join(" ", GetCoordinatesIntersection(Coordinates)));
    System.Console.WriteLine("Координата X точки пересечения = " + Math.Round(GetCoordinatesIntersection(Coordinates)[0], 1));
    System.Console.WriteLine("Координата Y точки пересечения = " + Math.Round(GetCoordinatesIntersection(Coordinates)[1], 1));
}
else
{
    System.Console.WriteLine("Координаты пересечения отсутствуют! ");
}


bool IsIntersection(double[,] array)
{
    double a = array[0, 0];
    double b = array[0, 1];
    double c = array[1, 0];
    double d = array[1, 1];

    if (a == c && b == d)
    {
        System.Console.WriteLine("Прямые совпадают (бесконечное множество точек пересечения)!");
        return false;
    }
    else if (a == c && b != d)
    {
        System.Console.WriteLine("Прямые параллельны! нет точек пересечения.");
        return false;
    }
    else if (a == 0 & b == 0 & c == 0 & d == 0)
    {
        System.Console.WriteLine("обе из прямых являются точкой в начале координат!");
        return false;
    }
    else
    {
        System.Console.WriteLine("Прямые пересекаются! ");
        return true;
    }


}



double[] GetCoordinatesIntersection(double[,] array)
{
    double x = 0;
    double y = 0;
    double a = array[0, 0];
    double b = array[0, 1];
    double c = array[1, 0];
    double d = array[1, 1];
    x = (d - b) / (a - c);
    y = a * x + b;
    double[] coordinatesIntersection = new double[2];
    coordinatesIntersection[0] = x;
    coordinatesIntersection[1] = y;

    return coordinatesIntersection;
}


void Print2DArray(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            System.Console.Write($" {array[i, j]} ");
        }
        System.Console.WriteLine();

    }
}

