using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Execuntado o Ex03 - Até Dez com For");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}