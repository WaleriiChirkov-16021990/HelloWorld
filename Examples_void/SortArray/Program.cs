
using System.ComponentModel.DataAnnotations;
void SortArray(int [] Array,int sort){
int size = Array.Length;
int index = 0;
// int min=0;
int max = 0;
int x = 0;

if(sort == 1){
     while(index<size){
    if(Array[index]>max){
        max = Array[index];
        x = Array[index];
        for (int i = index+1; i <= size-1; i++ ){
            Array[i-1] = Array[i];
        }
        Array[size-1]=x;
        }
           
    }
    index++;
  }
  Console.Write(string.Join(",", Array));

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
}
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


}

int [] Numbers = {5,1,10,67};
SortArray(Numbers,1);

