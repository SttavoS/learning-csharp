using System;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente();
        conta1.titular = "Gustavo";
        conta1.agencia = 8639;
        conta1.numero = 123456;
        conta1.saldo = 100;

        Console.WriteLine($"O titular da conta 1 é {conta1.titular}");

        conta1.Depositar(500);
        bool resultadoSaque = conta1.Sacar(200);
        Console.WriteLine($"O resultado do saque foi {resultadoSaque}");

        ContaCorrente conta2 = new ContaCorrente();
        conta1.Tranferir(150, conta2);
        Console.WriteLine($"O saldo da conta 1 é de R$ {conta1.saldo}");
        Console.WriteLine($"O saldo da conta 2 é de R$ {conta2.saldo}");
    }
}