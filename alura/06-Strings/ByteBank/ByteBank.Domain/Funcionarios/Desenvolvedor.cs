using System;

namespace ByteBank.Domain.Funcionarios;

public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome, string cpf) : base(nome, 3000, cpf) { }

    public override void AumentarSalario()
    {
        Salario *= 1.15;
    }

    public override double GetBonificacao()
    {
        return Salario * 0.1;
    }
}
