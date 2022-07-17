using System;

int[] arr = { 1, 4, 2, 7, 0, 12, 56, 2, 5, 7, 23 };
PrintArray(arr);
SelectionArray_Min_Max(arr);
PrintArray(arr);
SelectionArray_Max_Min(arr);
PrintArray(arr);





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

        int tempPosition = Array[i];
        Array[i] = Array[minPosition];
        Array[minPosition] = tempPosition;
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
        int tempPosition = ARRAY[i];
        ARRAY[i] = ARRAY[maxPosition];
        ARRAY[maxPosition] = tempPosition;
    }
}