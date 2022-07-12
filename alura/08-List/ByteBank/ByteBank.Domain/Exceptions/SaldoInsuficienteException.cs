using System.Runtime.Serialization;

namespace ByteBank.Domain.Exceptions;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException()
    {
    }

    public SaldoInsuficienteException(string? message) : base(message)
    {
    }
}