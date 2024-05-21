using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 12 - Loop For Aninhado");

        double investimento = 1000;
        double aliquota = 1.0036;
        int mes;
        int ano;

        for (ano = 0; ano < 5; ano++)
        {
            for (mes = 0; mes < 12; mes++)
            {
                investimento *= aliquota;
            }

            aliquota += 0.0010;
        }

        Console.WriteLine(
            "No decorrer de " + ano +
            " anos, você terá R$ " + investimento);

        Console.ReadLine(); 
    }
}