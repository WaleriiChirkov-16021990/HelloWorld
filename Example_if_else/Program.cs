Console.WriteLine("Add username: ");
string username = Console.ReadLine();

if( username.ToLower() == "маша")
{
    Console.WriteLine("Наконец-то!! Приветствую Маша!!!");

}
else {
    Console.WriteLine("Привет, " + username +"!");
}