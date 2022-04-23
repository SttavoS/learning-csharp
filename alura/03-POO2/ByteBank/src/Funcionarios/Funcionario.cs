using System;

namespace ByteBank.Funcionarios;

public abstract class Funcionario
{
    public string Nome { get; private set; }
    public string CPF { get; private set; }
    public double Salario { get; protected set; }
    
    public Funcionario(string nome, double salario, string cpf)
    {
        this.Nome = nome;
        this.CPF = cpf;
        this.Salario = salario;
    }
    
    public abstract void AumentarSalario();

    public abstract double GetBonificacao();
}
