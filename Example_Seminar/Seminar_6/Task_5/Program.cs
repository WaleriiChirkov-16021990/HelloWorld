
/*
Напишите программу, которая последовательно выводит числа от 1 до 100, но если число делится на 3 заменяет его на Fizz,
если делится на 5 заменяет его на Buzz, а если и 3 и 5 на FizzBuzz.
*/

for (int i = 1; i < 101; i++)
{

    if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine("FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        System.Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0)
    {
        System.Console.WriteLine("Fizz");
    }
    else
    {
        System.Console.WriteLine(i);
    }
}
