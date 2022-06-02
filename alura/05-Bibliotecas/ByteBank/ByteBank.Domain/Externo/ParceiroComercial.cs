using ByteBank.Domain.Sistema;
using System;

namespace ByteBank.Domain.Externo;

public class ParceiroComercial : IAutenticavel
{
    public string Senha { get; private set; }

    public ParceiroComercial(string senha)
    {
        this.Senha = senha;
    }

    public bool Autenticar(string senha)
    {
        return Senha == senha;
    }
}
