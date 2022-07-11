
using System;
void SortArray(int [] Array,int min, int max){
    // int [] Array = Array;
int [] sortedArray = QuickSort(Array, 0, Array.Length - 1);


Console.Write($"Sorted array : {string.Join(",", sortedArray )}");

// Console.ReadLine();


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


