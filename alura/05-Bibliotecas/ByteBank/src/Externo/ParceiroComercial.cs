using ByteBank.Sistema;
using System;

namespace ByteBank.Externo;

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
