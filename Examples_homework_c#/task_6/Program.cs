/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/



Console.WriteLine("Enter number: ");
int a = int.Parse(Console.ReadLine());

if (a%2==0){
    Console.WriteLine("Number : "+ a + " является чётным !");
}
else {
        Console.WriteLine("Number : "+ a + " является не чётным !");

}

