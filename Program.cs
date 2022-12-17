Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();
if(username.ToLower() == "Маша") // username.ToLower переводит все заглавные буквы в нижний регистр
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}