using System;

namespace ByteBank.Sistema;

public interface IAutenticavel
{
    bool Autenticar(string senha);
}
