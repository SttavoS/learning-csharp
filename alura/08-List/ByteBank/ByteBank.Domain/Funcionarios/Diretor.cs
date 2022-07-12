using ByteBank.Shared.Sistema;
using System;

namespace ByteBank.Domain.Funcionarios;

public class Diretor : FuncionarioAutenticavel
{
    public Diretor(string nome, string senha, string cpf) : base(nome, senha, 5000, cpf) { }

    public override void AumentarSalario()
    {
        Salario *= 1.15;
    }

    public override double GetBonificacao()
    {
        return Salario * 0.5;
    }
}
