using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 8 - Condicionais 2");

        int idade = 12;
        bool acompanhado = false;

        if (idade >= 18 || acompanhado) {
            Console.WriteLine("Acesso permitido");
        }
        else 
        {
            Console.WriteLine("Acesso negado");
        }

        Console.ReadLine();
    }
}