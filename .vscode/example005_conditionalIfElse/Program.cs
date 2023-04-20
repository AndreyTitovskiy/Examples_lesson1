Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ольга")
{
    Console.WriteLine("Ура это же ОЛЯ!");
}
    else
{
     Console.WriteLine("Привет:");
     Console.WriteLine(username);
 }