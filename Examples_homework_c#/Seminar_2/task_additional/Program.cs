
/*
Дополнительное задание: Напишите программу, которая принимает на вход число Number и выводит все простые числа в промежутке от 0 до Number (включительно). После, попробуйте поэксперментировать с величиной значения Number и понаблюдать за тем, как оно влияет на время выполнения программы.

Дополнительное задание не является обязательным и на оценку не влияет!
*/

Console.WriteLine("Введите целое положительное число :");

int N = int.Parse(Console.ReadLine());

int a = 2;


while (a <= N-1 )
{
    if (GetEasyNumber(a) == true)
    {
        Console.Write(a + ",");

    }
    a++;
}
if(GetEasyNumber(N)==true){
    
        Console.Write(N);
        Console.Write(" ");
}
if(GetEasyNumber(N) == false) 
{
        Console.Write(" N is not a prime number! ");
    
}

bool GetEasyNumber(int Number)
{
    for (int i = 2; i< Number; i++)
    {

        if (Number % i == 0)
            return false;
    }
    return true;
}




