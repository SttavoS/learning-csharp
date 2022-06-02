using System;

namespace ByteBank.Domain.Funcionarios;

public class Auxiliar : Funcionario
{
    public Auxiliar(string nome, string cpf) : base(nome, 2000, cpf) { }

    public override void AumentarSalario()
    {
        Salario *= 1.1;
    }

    public override double GetBonificacao()
    {
        return Salario * 0.2;
    }
}
