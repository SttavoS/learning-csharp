using System;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente gustavo = new Cliente();
            gustavo.nome = "Gustavo Schneider";
            gustavo.cpf = "123.456.789-10";
            gustavo.profissao = "Desenvolvedor";
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = gustavo;
            conta1.agencia = 8639;
            conta1.numero = 123456;
            conta1.saldo = 100;

            Console.WriteLine($"O titular da conta 1 é {conta1.titular.nome}");

            conta1.Depositar(500);
            bool resultadoSaque = conta1.Sacar(200);
            Console.WriteLine($"O resultado do saque foi {resultadoSaque}");

            ContaCorrente conta2 = new ContaCorrente();
            conta1.Tranferir(150, conta2);
            Console.WriteLine($"O saldo da conta 1 é de R$ {conta1.saldo}");
            Console.WriteLine($"O saldo da conta 2 é de R$ {conta2.saldo}");
        }
    }
}
