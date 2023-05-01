using System.Security.Cryptography;

Console.WriteLine("-- Rolagem de dados --");

Console.WriteLine("Digite quantas faces tem o dado..... ");
int faces = Convert.ToInt32(Console.ReadLine());

int rolagem = RandomNumberGenerator.GetInt32(1, faces);

Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"A rolagem do dado resultou em {rolagem}");
Console.ResetColor();
Console.WriteLine("");