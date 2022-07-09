/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("First number = " + a);
Console.WriteLine("Second number = " + b);

int max = a;

if( b>max ){
    max = b;
    Console.WriteLine("Max = Second_Number = " + max);
}
else{
    Console.WriteLine("Max = First_Number =  " + max);
}