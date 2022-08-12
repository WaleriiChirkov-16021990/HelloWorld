/*Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10*/
Console.WriteLine("ВВедите число: ");
int n = int.Parse(Console.ReadLine());
int[] res = new int[32];
int i = 0;
while (n > 0)
{
    res[i] = n % 2;
    i++;
    n = n / 2;
}
for (int j = i - 1; j >= 0; j--)
{
    Console.Write(res[j]);
}

