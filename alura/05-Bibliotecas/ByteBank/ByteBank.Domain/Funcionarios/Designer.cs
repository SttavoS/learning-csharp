using System;

namespace ByteBank.Domain.Funcionarios;

public class Designer : Funcionario
{
    public Designer(string nome, string cpf) : base(nome, 3000, cpf) { }

    public override void AumentarSalario()
    {
        Salario *= 1.11;
    }

    public override double GetBonificacao()
    {
        return Salario * 0.17;
    }
}
