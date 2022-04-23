using System;

namespace ByteBank;

public class Program
{
    static void Main(string[] args)
    {
        Cliente gustavo = new Cliente("Gustavo Schneider", "123.456.789-10", "Desenvolvedor");
        ContaCorrente conta1 = new ContaCorrente(gustavo, 863);

        Console.WriteLine($"O titular da conta 1 é {conta1.Titular.Nome}");
        Console.WriteLine($"A agência da conta é {conta1.Agencia} e o número {conta1.Numero}");
        Console.WriteLine($"Com saldo de {conta1.Saldo}");

        conta1.Depositar(500);
        Console.WriteLine($"Saldo após o deposito é de {conta1.Saldo}");
        conta1.Sacar(200);
        Console.WriteLine($"Saldo após o saque é de {conta1.Saldo}");
    }
}
