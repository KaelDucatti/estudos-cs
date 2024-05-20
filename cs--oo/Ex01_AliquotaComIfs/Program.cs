using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 10 - Ex01");

        double salario = 3300.0;
        double IR;
        string deducao = "";

        if (salario >= 3751.01)
        {
            IR = salario * 0.225;
            deducao = "Dedução de até R$ 636";

        }
        else if (salario >= 2800.01)
        {
            IR = salario * 0.15;
            deducao = "Dedução de até R$ 350";  
        }
        else if (salario >= 1900)
        {
            IR = salario * 0.075;
            deducao = "Dedução de até R$ 142";
        }
        else 
        {
            IR = 0;
        }

        if (IR != 0) 
        {
            Console.WriteLine("IR: " + IR);
            Console.WriteLine(deducao);
        }
        else 
        {
            Console.WriteLine("Não precisa fazer declaração");
        }
        
        Console.ReadLine();
    }
}