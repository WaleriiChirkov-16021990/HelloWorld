void ReverseArray(int [] array){
    int size = array.Length;
    int index = 0;
    int x=0;

   
    while ( index < size-index-1){
        x=array[index];
        array[index]=array[size-index-1];
        array[size-index-1]=x;
        index++;
    }
    Console.WriteLine(string.Join("," , array ));
}


// int [] Numbers = {14,34,47,345,13,0,5,67,100,400};
// ReverseArray(Numbers);