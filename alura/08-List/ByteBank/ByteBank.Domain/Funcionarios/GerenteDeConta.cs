using ByteBank.Shared.Sistema;
using System;

namespace ByteBank.Domain.Funcionarios;

public class GerenteDeConta : FuncionarioAutenticavel
{
    public GerenteDeConta(string nome, string senha, string cpf) : base(nome, senha, 4500, cpf) { }

    public override void AumentarSalario()
    {
        Salario *= 1.05;
    }

    public override double GetBonificacao()
    {
        return Salario * 0.25;
    }
}
