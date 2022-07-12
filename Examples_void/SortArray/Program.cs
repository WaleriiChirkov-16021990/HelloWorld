
using System;
void SortArray(int [] Array,int min, int max){

int [] sortedArray = QuickSort(Array, 0, Array.Length - 1);


Console.Write($"Sorted array : {string.Join(",", sortedArray )}");

 Console.ReadLine();


int [] QuickSort(int [] Array , int minIndex, int maxIndex)
{
    if (minIndex>=maxIndex)
    {
        return Array;
    }
    int pivotIndex = GetPivotIndex(Array, minIndex, maxIndex) ;

    QuickSort(Array,minIndex,pivotIndex-1);

    QuickSort(Array,pivotIndex+1,maxIndex);

return Array;
}

int GetPivotIndex(int [] Array, int minIndex, int maxIndex )
{
    int pivot =minIndex-1;

    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (Array[i]<Array[maxIndex])
        {
            pivot++;
            Swap(ref Array[pivot], ref Array[i]);
        }
    }

     pivot++;
     
     Swap(ref Array[pivot], ref Array[maxIndex]);

    return pivot;
}

void Swap(ref int leftItem, ref int rightItem)
{
            int x = leftItem;
            leftItem= rightItem;
            rightItem= x ;

}

}     // delete } for start after version//

int [] Numbers = {5,1,10,67,6,4,0,99,95,84,30};
SortArray (Numbers,0,7);
