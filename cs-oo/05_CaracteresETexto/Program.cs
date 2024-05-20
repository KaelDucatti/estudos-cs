using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 5 - Caracteres e Textos");

        // character
        char firtsLetter;
        
        firtsLetter = 'a';
        Console.WriteLine(firtsLetter);

        firtsLetter = (char)39;
        Console.WriteLine(firtsLetter);

        firtsLetter = (char)(firtsLetter + 1);
        Console.WriteLine(firtsLetter);

        string text = "Alura: Cursos de Tecnologia " + 2024;
        Console.WriteLine(text);

        Console.ReadLine();
    }
}