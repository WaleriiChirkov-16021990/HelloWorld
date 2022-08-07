// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

bool Contains(int[] array, int n)
{
    for (int i = 0; array.Length > i; i++)
    {
        if (array[i] == n)
        {
            return true;
        }
    }
    return false;
}


Console.WriteLine("Введите размерность массива");
int len = int.Parse(Console.ReadLine());
int[] arr = GetArray(len);

Console.WriteLine("Введите число");
int chisloP = int.Parse(Console.ReadLine());

PrintArray(arr);

if (Contains(arr, chisloP))
{
    Console.WriteLine("Да, это число есть в массиве");
}
else
{
    Console.WriteLine("Нет, этого числа нет в массиве");
}