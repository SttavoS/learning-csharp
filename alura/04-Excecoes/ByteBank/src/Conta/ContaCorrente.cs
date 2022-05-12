using ByteBank.Exceptions;

namespace ByteBank.Conta;

public class ContaCorrente
{
    public Cliente Titular { get; private set; }
    public int Agencia { get; private set; }
    public string Numero { get; private set; }
    public double Saldo { get; private set; }

    public ContaCorrente(Cliente titular, int agencia)
    {
        Titular = titular;
        Agencia = agencia;
        Numero = $"{agencia}-{new Random().Next(0, 99999)}";
        Saldo = 100.0;
        Validar();
    }

    private void Validar()
    {
        if (Agencia <= 0)
            throw new ArgumentException("O número da agência não pode ser menor que 1.", nameof(Agencia));
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor < 0)
            throw new ArgumentException("Você não pode realizar um saque com valor negativo.");

        if (Saldo < valor)
            throw new SaldoInsuficienteException($"Tentativa de saque de {valor} com saldo de {Saldo}.");

        Saldo -= valor;
    }

    public void Tranferir(double valor, ContaCorrente contaDestino)
    {
        if (Saldo < valor)
            throw new SaldoInsuficienteException($"Tentativa de tranferência de {valor} com saldo de {Saldo}.");

        Sacar(valor);
        contaDestino.Depositar(valor);
    }
}
