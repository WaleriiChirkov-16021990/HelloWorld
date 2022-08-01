
using System;

int[] arr = { 1, 4, 2, 7, 0, 12, 56, 2, 5, 7, 23 };
PrintArray(arr);
SelectionArray_Min_Max(arr);
PrintArray(arr);
SelectionArray_Max_Min(arr);
PrintArray(arr);
Console.ReadLine();





void PrintArray(int[] array)
{
    int count = array.Length;

    for (var i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

void SelectionArray_Min_Max(int[] Array)
{
    for (int i = 0; i < Array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < Array.Length; j++)
        {
            if (Array[j] < Array[minPosition]) minPosition = j;

        }

        SwapI(ref Array[i], ref Array[minPosition]);
    }
}

void SelectionArray_Max_Min(int[] ARRAY)
{
    for (int i = 0; i < ARRAY.Length - 1; i++)
    {
        int maxPosition = i;
        for (var j = i + 1; j < ARRAY.Length; j++)
        {
            if (ARRAY[j] > ARRAY[maxPosition]) maxPosition = j;
        }
        SwapI(ref ARRAY[maxPosition], ref ARRAY[i]);
    }
}

void SwapI(ref int leftItem, ref int rightItem)
{
    int tempPosition = leftItem;
    leftItem = rightItem;
    rightItem = tempPosition;
}
