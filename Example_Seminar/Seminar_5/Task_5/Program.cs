using System;
/*
[1,3,5,7]
[2,4,6,8,9]
->
[1,2,3,4,5,6,7,8]

[]
*/

int[] array1 = { 1, 3, 5, 7 };
int[] array2 = { 2, 4, 9, 8 };

System.Console.WriteLine("Массив 1 : {0} ", String.Join(" ", array1));
System.Console.WriteLine("Массив 2 : {0} ", String.Join(" ", array2));
System.Console.WriteLine();

GetCommonSortArray(array2, array1);


void GetCommonSortArray(int[] array1, int[] array2)
{

    int[] CommonArray = GetCommonArray(array1, array2);
    System.Console.WriteLine("Суммарный массив : ");
    PrintArray(CommonArray);
    SelectionArray_Min_Max(CommonArray);
    System.Console.WriteLine("Суммарный отсортированный массив : ");
    PrintArray(CommonArray);

    int[] GetCommonArray(int[] array1, int[] array2)
    {

        int[] commonArray = new int[array1.Length + array2.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            commonArray[i] = array1[i];
        }

        for (int i = 0; i < array2.Length; i++)
        {
            commonArray[commonArray.Length - i - 1] = array2[array2.Length - i - 1];
        }
        return commonArray;
    }




    void PrintArray(int[] array)
    {
        System.Console.WriteLine(String.Join(" ", array));
        System.Console.WriteLine();
    }

    void SelectionArray_Min_Max(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minPosition]) minPosition = j;

            }
            Swap(ref array[i], ref array[minPosition]);
        }
    }

    void Swap(ref int leftItem, ref int rightItem)
    {
        int tempPosition = leftItem;
        leftItem = rightItem;
        rightItem = tempPosition;
    }
}