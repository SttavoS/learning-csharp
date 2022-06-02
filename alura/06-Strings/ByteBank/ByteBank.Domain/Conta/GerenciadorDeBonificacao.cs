using ByteBank.Domain.Funcionarios;

namespace ByteBank;

public class GerenciadorDeBonificacao
{
    private double _totalBonificacao;

    public void Registrar(Funcionario funcionario)
    {
        _totalBonificacao += funcionario.GetBonificacao();
    }

    public double GetTotalBonificacao()
    {
        return _totalBonificacao;
    }
}
