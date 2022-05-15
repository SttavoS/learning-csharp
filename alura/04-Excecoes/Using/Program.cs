public class Program
{
    static void Main(string[] args)
    {
        using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
        {
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();
        }
    }
}
