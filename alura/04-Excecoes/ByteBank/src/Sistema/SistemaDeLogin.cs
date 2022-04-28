using System;
using ByteBank.Funcionarios;

namespace ByteBank.Sistema;

public class SistemaDeLogin
{
    public bool Logar(IAutenticavel funcionario, string senha)
    {
        bool usuarioAutenticado = funcionario.Autenticar(senha);

        if (!usuarioAutenticado)
        {
            Console.WriteLine("Senha incorreta!");
            return false;
        }

        Console.WriteLine("Bem-vindo ao sistema!");
        return true;        
    }
}
