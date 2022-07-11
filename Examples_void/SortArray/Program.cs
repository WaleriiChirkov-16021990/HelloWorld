
using System;
void SortArray(int [] Array,int min, int max){
    int [] array1 = Array;
int [] sortedArray = QuickSort(Array, 0, Array.Length - 1);


Console.Write($"Sorted array : {string.Join(",", sortedArray )}");

Console.ReadLine();


int [] QuickSort(int [] Array , int minIndex, int maxIndex)
{
    if (minIndex>=maxIndex)
    {
        return array1;
    }
    int pivotIndex = GetPivotIndex(array1, minIndex, maxIndex) ;

    QuickSort(array1,minIndex,pivotIndex-1);

    QuickSort(array1,pivotIndex+1,maxIndex);

return Array;
}

int GetPivotIndex(int [] array1, int minIndex, int maxIndex )
{
    int pivot =minIndex-1;

    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (array1[i]<array1[minIndex])
        {
            pivot++;
            Swap(ref array1[pivot], ref array1[i]);
        }
    }

     pivot++;
     Swap(ref array1[pivot], ref array1[maxIndex]);

    return pivot;
}

void Swap(ref int leftnum, ref int rightnum)
{
            int x = leftnum;
            leftnum= rightnum;
            rightnum= x ;

}

}     // delete } for start after version//

// while(index<size){
//     if(Array[index]> max){
//         max = Array[index];
//     }
//     index++;
// }
// Array[0]=max;

// if(sort == 1){
//      while(index<size){
//          if()




    // if(Array[index]>max){
    //     max = Array[index];
    //     x = Array[index];
    //     for (int i = index+1; i <= size-1; i++ ){
    //         Array[i-1] = Array[i];
    //     }
    //     Array[size-1]=x;
    //     }
           
//     }
//     index++;
//   }
//   Console.Write(string.Join(",", Array));

    // while (index<size){
    //  index =1;
    //  if ( Array[index]< min){
    //     Array[index]= min;
    //     x=Array[index];
    
    //     for(int i = index-1; i > 0; i=i-1){
    //         Array[i]=Array[i+1];
    //                 }
    //     Array[0]=x;
       
    //  }
    //  return;
    // }
    // Console.Write(string.Join(",", Array));
    // Console.WriteLine(min);
// }
// else {
//     while (index<size){
//      index =1;
//      if ( Array[index]> max){
//         Array[index]= max;
//         x=Array[index];
    
//         for(int i = index-1; i > 0; i=i-1){
//             Array[i]=Array[i+1];
//                     }
//         Array[size-1]=x;
       
//      }
//      return;
//     }
//     Console.Write(string.Join(",", Array));
//     Console.WriteLine(max);

// }


// }

int [] Numbers = {5,1,10,67,6,4,0};
SortArray(Numbers,0,6);

