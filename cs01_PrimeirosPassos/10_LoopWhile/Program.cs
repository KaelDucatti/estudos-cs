using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 10 - Loops com While");

        double valorInvestido = 1000;
        int contaMes = 1;

        while (contaMes <= 12)
        {
            valorInvestido += valorInvestido * 0.0036;
            Console.WriteLine("Após " + contaMes + " mẽses, você terá " + valorInvestido);
            contaMes++;
        }
        
        Console.ReadLine();
    }
}