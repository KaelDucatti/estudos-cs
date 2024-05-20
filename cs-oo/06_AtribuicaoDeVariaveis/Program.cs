using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 6 - Atribuição de Variáveis");

        int idade;
        int idadeMikael;

        idade = 24;
        idadeMikael = idade;

        Console.WriteLine(idade);
        Console.WriteLine(idadeMikael);

        idade = 30;

        Console.WriteLine(idade);
        Console.WriteLine(idadeMikael);
        
        Console.ReadLine();
    }
}