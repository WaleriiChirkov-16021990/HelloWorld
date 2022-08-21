/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1  2  3  4
12 13 14 5
11 16 15 6
10 9  8  7 */
Console.Clear();
System.Console.WriteLine("Данная программа заполняет спиралью массив 4х4 и любого другого размера!");
System.Console.Write("Введите количество строк и столбцов генерируемой целочисленной матрици \nввод через пробел: ");
string[] input1 = Console.ReadLine().Split();
int[,] rndArray1 = FillArray(input1);
System.Console.WriteLine("\nМатрица заполнена по спирали:");
PrintArray(rndArray1);

int[,] FillArray(string[] input)
{
    int[,] array = new int[int.Parse(input[0]), int.Parse(input[1])];

    for (int k = 0, item = 0;
        k <= int.Parse(input[0]) / 2; k++)
    {
        for (int j = k, i = k;
            j < int.Parse(input[1]) - 1 - k; j++)
        {
            GetItemArray(ref array[i, j], ref item);
        }
        for (int j = int.Parse(input[1]) - 1 - k, i = k;
                 i < int.Parse(input[0]) - 1 - k; i++)
        {
            GetItemArray(ref array[i, j], ref item);
        }
        for (int i = int.Parse(input[0]) - 1 - k,
                 j = int.Parse(input[1]) - 1 - k;
                 j >= k; --j)
        {
            GetItemArray(ref array[i, j], ref item);
        }
        for (int i = int.Parse(input[0]) - 2 - k, j = k;
             i >= k + 1; --i)
        {
            GetItemArray(ref array[i, j], ref item);
        }
    }
    return array;
}

void GetItemArray(ref int element, ref int item)
{
    if (element == 0) element = ++item;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}