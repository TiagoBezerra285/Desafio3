using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisores = 0;

            Console.WriteLine("Entre com um Número Inteiro");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
                if(numero % i == 0)
                    divisores++;
                
            if(divisores == 2)
            {
                Console.WriteLine("O "+ numero + " é Primo");
            }
            else
            {
                Console.WriteLine("O " + numero + " não e Primo");
            }
            
        }
    }
}
