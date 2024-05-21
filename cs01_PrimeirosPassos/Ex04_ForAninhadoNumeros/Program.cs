using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Ex04 - For aninhado com números");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(j + 1);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}