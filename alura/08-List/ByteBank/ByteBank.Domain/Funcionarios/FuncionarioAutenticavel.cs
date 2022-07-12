using ByteBank.Shared.Sistema;
using System;

namespace ByteBank.Domain.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; private set; }

        public FuncionarioAutenticavel(string nome, string senha, double salario, string cpf)
            : base(nome, salario, cpf)
        {
            this.Senha = senha;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
