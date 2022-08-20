using System;
System.Console.Write("Введите количество строк и столбцов массива через пробел: ");
string[] input = Console.ReadLine().Split();
int[,] array = new int[int.Parse(input[0]), int.Parse(input[1])];
Random rnd = new Random();
for (int i = 0; i < int.Parse(input[0]); i++)
{
    for (int j = 0; j < int.Parse(input[1]); j++)
    {
        array[i, j] = rnd.Next(-50, 51);
    }
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < int.Parse(input[0]); i++)
    {
        for (int j = 0; j < int.Parse(input[1]); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
