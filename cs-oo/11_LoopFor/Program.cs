using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 11 - Laço for");

        double valorInvestido = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            valorInvestido *= 1.0036;
            Console.WriteLine(
                "Após " + mes +
                " meses, você terá " + valorInvestido);
        }
        
        Console.ReadLine();
    }
}