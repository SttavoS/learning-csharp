namespace ByteBank.Conta;

public class ContaCorrente
{
    public Cliente Titular { get; private set; }
    public int Agencia { get; private set; }
    public string Numero { get; private set; }
    public double Saldo { get; private set; }

    public ContaCorrente(Cliente titular, int agencia)
    {
        this.Titular = titular;
        this.Agencia = agencia;
        this.Numero = $"{agencia}-{new Random().Next(0, 99999)}";
        this.Saldo = 100.0;
        Validar();
    }

    private void Validar()
    {
        if (Agencia <= 0)
            throw new ArgumentException("O número da agência não pode ser menor que 1.", nameof(Agencia));
    }

    public void Depositar(double valor)
    {
        this.Saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (this.Saldo < valor)
        {
            return false;
        }

        this.Saldo -= valor;
        return true;
    }

    public bool Tranferir(double valor, ContaCorrente contaDestino)
    {
        if (this.Saldo < valor)
        {
            return false;
        }

        this.Saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}
