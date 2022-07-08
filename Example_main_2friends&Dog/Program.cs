int Dist = 10000; 
int v1 = 1; 
int v2 = 2; 
int v3 = 5; 
int count = 0; 
int Friend = 2;   
int t =0; 

while(Dist>10){        
   if(Friend==1){        
       t = Dist/(v1+v3);            
       Dist = Dist - (v1+v2)*t;
       Friend= 2;   
        }
   
     else {  
        t = Dist/(v2+v3);      
        Dist = Dist - (v1+v2)*t;
        Friend= 1;   
         }
        count++;   
}
Console.WriteLine("Собака пробежит " + count + " раз !");