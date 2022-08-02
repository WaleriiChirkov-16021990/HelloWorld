/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

*/

int[] FillArray(int n)
{
    int[] Array = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rnd.Next(0, 2);
    }

    return Array;
}

Console.WriteLine("Введите размерность массива : ");
int size = int.Parse(Console.ReadLine());

int[] Arr = FillArray(size);

for (int i = 0; i < Arr.Length; i++)
{
    Console.Write(Arr[i] + " ");
}