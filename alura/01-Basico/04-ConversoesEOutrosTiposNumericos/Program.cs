using System;

namespace _04_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1975.50;
            // Casting
            int valor = (int)salario;
            System.Console.WriteLine($"O salário em inteiro é {valor}");

            // long - 64 bits
            long idadeDoUniverso = 14000000000;
            System.Console.WriteLine($"A idade do universo é {idadeDoUniverso} de anos.");

            // short
            short qtdeProdutos = 150;           
            System.Console.WriteLine($"Tem {qtdeProdutos} produtos no estoque!");
        }
    }
}
