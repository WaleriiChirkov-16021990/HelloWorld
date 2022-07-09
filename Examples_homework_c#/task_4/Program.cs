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
