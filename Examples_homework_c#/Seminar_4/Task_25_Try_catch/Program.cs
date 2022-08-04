/*
Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.

*/
while (true)
{
    Console.Clear();
    Console.WriteLine("Программа принимает на вход два числа и возводит число A в натуральную степень B");
    double number;
    int degree;
    try
    {
        Console.Write("Введите число : ");
        number = double.Parse(Console.ReadLine());
        Console.Write("Введите степень: ");
        degree = int.Parse(Console.ReadLine());

    }
    catch (Exception)
    {
        Console.Write("Недопустимое значение! Введите число и натуральную степень!! (1,2,3,4....) ");
        Console.ReadLine();
        continue;
    }
    Console.WriteLine(" Число " + number + " в степени " + degree + " = " + Math.Round(Math.Pow(number, degree), 3));
    Console.ReadLine();
}

