Console.WriteLine("Как тебя зовут?");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет, наконец-то ты пришла!");
} 
else
{
    Console.Write("Здравствуйте! ");
    Console.WriteLine(username);
}

