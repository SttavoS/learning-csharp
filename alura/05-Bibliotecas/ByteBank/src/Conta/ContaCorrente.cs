using ByteBank.Exceptions;

namespace ByteBank.Conta;

/// <summary>
/// Classe que representa uma Conta Corrente
/// </summary>
public class ContaCorrente
{
    /// <summary>
    /// Representa um <see cref="Titular"/> de uma <see cref="ContaCorrente"/>
    /// </summary>
    public Cliente Titular { get; private set; }

    /// <summary>
    /// Representa uma <see cref="Agencia"/> de uma <see cref="ContaCorrente"/>
    /// </summary>
    public int Agencia { get; private set; }

    /// <summary>
    /// Representa o <see cref="Numero"/> de uma <see cref="ContaCorrente"/>
    /// </summary>
    public string Numero { get; private set; }

    /// <summary>
    /// Representa o <see cref="Numero"/> de uma <see cref="ContaCorrente"/>
    /// </summary>
    public double Saldo { get; private set; }

    /// <summary>
    /// Contrutor da classe <see cref="ContaCorrente"/>
    /// </summary>
    /// <param name="titular">Parâmetro <see cref="Titular"/> representa o titlar de uma conta corrente</param>
    /// <param name="agencia">Parâmetro <see cref="Agencia"/> representa a agência de uma conta corrente</param>
    public ContaCorrente(Cliente titular, int agencia)
    {
        Titular = titular;
        Agencia = agencia;
        Numero = $"{agencia}-{new Random().Next(0, 99999)}";
        Saldo = 100.0;
        Validar();
    }

    /// <summary>
    /// Valida os dados recebidos no construtor
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    private void Validar()
    {
        if (Agencia <= 0)
            throw new ArgumentException("O número da agência não pode ser menor que 1.", nameof(Agencia));
    }

    /// <summary>
    /// Realiza o depósito
    /// </summary>
    /// <param name="valor">A quantia que será depositada</param>
    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    /// <summary>
    /// Realiza o saque
    /// </summary>
    /// <param name="valor">A quantia que será sacada</param>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="SaldoInsuficienteException"></exception>
    public void Sacar(double valor)
    {
        if (valor < 0)
            throw new ArgumentException("Você não pode realizar um saque com valor negativo.");

        if (Saldo < valor)
            throw new SaldoInsuficienteException($"Tentativa de saque de {valor} com saldo de {Saldo}.");

        Saldo -= valor;
    }

    /// <summary>
    /// Realiza uma tranferência monetária entre duas contas
    /// </summary>
    /// <param name="valor">A quantia que será transferida</param>
    /// <param name="contaDestino">A conta que o valor será transferido. Uma instância de <see cref="ContaCorrente"/></param>
    /// <exception cref="SaldoInsuficienteException"></exception>
    /// <exception cref="OperacaoFinanceiraException"></exception>
    public void Tranferir(double valor, ContaCorrente contaDestino)
    {
        if (Saldo < valor)
            throw new SaldoInsuficienteException($"Tentativa de tranferência de {valor} com saldo de {Saldo}.");

        try
        {
            Sacar(valor);
        }
        catch (SaldoInsuficienteException ex)
        {
            throw new OperacaoFinanceiraException("Operação não realizada.", ex);
        }
        contaDestino.Depositar(valor);
    }
}
