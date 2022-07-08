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