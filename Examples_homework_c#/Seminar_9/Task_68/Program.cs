/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/

System.Console.WriteLine("Введите 2 неотрицательных числа через пробел: ");
string[] input = Console.ReadLine().Split();
int m = int.Parse(input[0]);
int n = int.Parse(input[1]);

Console.Write(A(m, n));

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 & n == 0)
    {
        return A(m - 1, 1);
    }
    if (m > 0 & n > 0)
    {
        return A(m - 1, A(m, n - 1));
    }
    return A(m, n);
}