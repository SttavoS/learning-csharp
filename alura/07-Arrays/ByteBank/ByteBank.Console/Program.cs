using ByteBank.Domain.Conta;
using ByteBank.Domain.Funcionarios;
using ByteBank.Domain.Sistema;
using ByteBank.Domain.Externo;
using ByteBank.Domain.Exceptions;

namespace ByteBank;

public class Program
{
    static void Main(string[] args)
    {
        // CriarConta();
        CriaListaDeContas();
        // CalcularBonificacao();
        // UsarSistema();
    }

    public static void CriarConta()
    {
        try
        {
            var gustavo = new Cliente("Gustavo Schneider", "123.456.789-10", "Desenvolvedor");
            var conta1 = new ContaCorrente(gustavo, 863);

            Console.WriteLine($"O titular da conta 1 é {conta1.Titular.Nome}");
            Console.WriteLine($"A agência da conta é {conta1.Agencia} e o número {conta1.Numero}");
            Console.WriteLine($"Com saldo de {conta1.Saldo}");

            conta1.Depositar(500);
            Console.WriteLine($"Saldo após o deposito é de {conta1.Saldo}");
            conta1.Sacar(-1000);
            Console.WriteLine($"Saldo após o saque é de {conta1.Saldo}");
        }
        catch (SaldoInsuficienteException exp)
        {
            Console.WriteLine(exp.Message);
        }
        catch (ArgumentException exp)
        {
            Console.WriteLine(exp.Message);
        }
    }

    public static void CalcularBonificacao()
    {
        var gerenciador = new GerenciadorDeBonificacao();

        var pedro = new Designer("Pedro", "833.222.048-39");
        var roberta = new Diretor("Roberta", "123", "159.753.398-04");
        var igor = new Auxiliar("Igor", "981.198.778-53");
        var camila = new GerenteDeConta("Camila", "456", "326.985.628-89");
        var guilherme = new Desenvolvedor("Guilherme", "456.175.468-20");

        gerenciador.Registrar(guilherme);
        gerenciador.Registrar(pedro);
        gerenciador.Registrar(roberta);
        gerenciador.Registrar(igor);
        gerenciador.Registrar(camila);

        Console.WriteLine($"Total de bonificações do mês {gerenciador.GetTotalBonificacao()}");
    }

    public static void UsarSistema()
    {
        var sistemaInterno = new SistemaDeLogin();

        var roberta = new Diretor("Roberta", "123", "159.753.398-04");
        var camila = new GerenteDeConta("Camila", "abc", "326.985.628-89");

        var parceiro = new ParceiroComercial("123456");

        sistemaInterno.Logar(parceiro, "123456");
        sistemaInterno.Logar(roberta, "123");
        sistemaInterno.Logar(camila, "abc");
    }

    public static void CriaListaDeContas()
    {
        var joaozinho = new Cliente("Joãozinho", "45678912345", "Pedreiro de Software");
        var mariazinha = new Cliente("Mariazinha", "8489498451684", "Arquiteta de Software");
        var contaDaMariazinha = new ContaCorrente(mariazinha, 456);
        var lista = new ListaDeContaCorrentes();
        lista.Adicionar(new ContaCorrente(joaozinho, 123));
        lista.Adicionar(new ContaCorrente(joaozinho, 123));
        lista.Adicionar(new ContaCorrente(joaozinho, 123));
        lista.Adicionar(new ContaCorrente(joaozinho, 123));
        lista.Adicionar(new ContaCorrente(joaozinho, 123));
        lista.Adicionar(contaDaMariazinha);
        lista.Adicionar(new ContaCorrente(joaozinho, 123));
        lista.Adicionar(new ContaCorrente(joaozinho, 123));
        lista.Adicionar(new ContaCorrente(joaozinho, 123));

        // lista.EscreverListaInteira();
        lista.Remover(contaDaMariazinha);
        // lista.EscreverListaInteira();
        Console.WriteLine(lista.GetItemNoIndice(4).Numero);
    }
}
