using System;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente conta = new ContaCorrente();
        conta.titular = "Gustavo";
        conta.agencia = 8639;
        conta.numero = 123456;
        conta.saldo = 100;

        Console.WriteLine($"O titular da conta é {conta.titular}");
    }
}