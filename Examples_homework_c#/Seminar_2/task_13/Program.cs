/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


Console.WriteLine(" Введите любое целое число: ");
long num = long.Parse(Console.ReadLine());
int i = 1;

while (i <= num / 10)
{
    i = i * 10;
}

if (i < 100)
{
    Console.WriteLine("Третьей цифры нет в данном числе!");
}
else
{
    long theThird = (((num % i) % (i / 10)) % i - (num % (i / 100))) / (i / 100);
    Console.WriteLine("Третья цифра вашего числа " + theThird);

}