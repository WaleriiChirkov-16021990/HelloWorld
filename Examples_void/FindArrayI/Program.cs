
int FindArrayI(int  Array,int find)
{
int [] array = Array[Array.Length];
int index = 0;
// int count = -1;
int size = Array.Length;

while( index< size ) {
    int count = -1;
    if(Array[index]==find){
        count = index;
        break;
    }
    index++;

}
return count;

}

int [] Array  = {1,4,6,1,7,8,23,46,78,90};
int count =  FindArrayI(Array, 46);
Console.WriteLine(count);