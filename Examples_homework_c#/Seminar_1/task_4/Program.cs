/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/




Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("First number = " + a);
Console.WriteLine("Second number = " + b);
Console.WriteLine("The third number = " + c);

int max = a;

    if( b > max ){
        max = b;
    
    }
    if( c > max ){
        max = c;
        
    }
    if( a >= max ){
        max = a;
    }
Console.WriteLine("max = " + max);
