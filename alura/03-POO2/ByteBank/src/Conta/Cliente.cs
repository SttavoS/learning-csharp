namespace ByteBank.Conta;

public class Cliente
{
    public string Nome { get; private set; }
    public string Cpf { get; private set; }
    public string Profissao { get; private set; }

    public Cliente(string nome, string cpf, string profissao)
    {
        this.Nome = nome;
        this.Cpf = cpf;
        this.Profissao = profissao;
    }
}    
