
/*
В этом примере пытаюсь понять как создавать перегрузки методов
*/


using System;
namespace Lectra
{
    class Program
    {



        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }


        static void Main(string[] agrs)
        {
            Console.WriteLine(Sum(3, 6, 9));

        }

    }

}