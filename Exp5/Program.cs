﻿Console.Write("Введите имя пользовател: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("Ура, это Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}