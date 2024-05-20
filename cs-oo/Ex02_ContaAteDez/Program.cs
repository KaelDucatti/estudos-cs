using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Exercício 02 - Conta até dez");

        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }
        
        Console.ReadLine();
    }
}