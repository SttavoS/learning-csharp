namespace ByteBank.Domain.Exceptions;

public class OperacaoFinanceiraException : Exception
{
    public OperacaoFinanceiraException()
    {
    }

    public OperacaoFinanceiraException(string messag)
        : base(messag)
    {
    }

    public OperacaoFinanceiraException(string messag, Exception innerException)
        : base(messag, innerException)
    {
    }
}