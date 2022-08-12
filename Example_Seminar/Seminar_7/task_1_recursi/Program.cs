/*
Найти факториал числа через рекурсию
*/


System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Factorial(num));

int Factorial(int number)
{
    if (number == 1)
    {
        return number;
    }

    return number * Factorial(number - 1);
}