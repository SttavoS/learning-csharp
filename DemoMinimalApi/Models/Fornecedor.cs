namespace DemoMinimalApi.Models;

class Fornecedor
{
    public Guid Id { get; set; }
    public string? Nome { get; set; }
    public string? Documento { get; set; }
    public bool Ativo { get; set; }
}
