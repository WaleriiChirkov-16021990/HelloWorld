/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Enter number (N>1): ");
int a = int.Parse(Console.ReadLine());
int x = 2;

while (x<=a){
     if (x%2==0 ){
      Console.Write(x +" ");
     }
     x++;
}
