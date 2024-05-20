using System;

namespace Escopos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 9 - Escopos");

            int idade = 15;
            bool acompanhado = true;

            if (idade >= 18 || acompanhado)
            {
                string nome = "Mikael";
                Console.WriteLine("Acesso permitido");
            }
            else 
            {
                Console.WriteLine("Acesso negado");
            }

            // não irá rodar, a var nome foi criada em outro escopo
            // Console.WriteLine(nome); 
            Console.ReadLine();
        }
    }
}