/*
**Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Например, изначально массив выглядел вот так:

1 4 7 2

5 9 2 3

8 4 2 4

Новый массив будет выглядеть вот так:

1 4 7 2

5 **81** 2 **9**

8 4 2 4
*/

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 2;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();

    }
}

void PowerEven(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }

    }
}

Console.WriteLine("Введите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int rows = int.Parse(input[0]);
int columns = int.Parse(input[1]);
int[,] myArray = GetArray(rows, columns);
PowerEven(myArray);
PrintArray(myArray);

