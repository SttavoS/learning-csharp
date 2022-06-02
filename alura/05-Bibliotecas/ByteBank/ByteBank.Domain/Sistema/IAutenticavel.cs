using System;

namespace ByteBank.Domain.Sistema;

public interface IAutenticavel
{
    bool Autenticar(string senha);
}
