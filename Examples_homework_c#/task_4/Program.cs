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

    if( b>max ){
        max = b;
        Console.WriteLine("Max = Second_Number = " + max);
    }
      else if( c>max ){
        max=c;
        Console.WriteLine("Max = The third = " + max);
    }
      else{
        Console.WriteLine("Max = First_Number =  " + max);
    }
