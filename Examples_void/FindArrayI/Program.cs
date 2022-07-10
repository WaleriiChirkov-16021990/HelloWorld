
int FindArrayI(int [] Array,int find)
{
    int count = -1;
    int index = 0;
    int size = Array.Length;

while( index< size ) {
    
    if(Array[index]==find){
        count = index;
        break;
    }
    index++;

}
return count;

}

// int [] Array  = {1,4,6,1,7,8,23,46,78,90};
// int count =  FindArrayI(Array, 90);
// Console.WriteLine(count);