using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 7 - Condicionais");

        int idade = 16;
        int numPessoas = 2;

        if (idade >= 18)
        {
            Console.WriteLine("Acesso permitido");
        }
        else
        {
            if (numPessoas >= 2)
            {
                Console.WriteLine("Acesso permitido. Menor de idade acompanhado");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
        }

        Console.ReadLine();
    }
}