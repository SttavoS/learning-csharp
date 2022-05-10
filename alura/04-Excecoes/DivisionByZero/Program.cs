public class Program
{
    static void Main(string[] args)
    {
        try
        {
            int number = 10;
            int zero = 0;

            int divisao = Dividir(number, zero);

            Console.WriteLine(divisao);
        }
        catch (DivideByZeroException)
        {

            Console.WriteLine("Tentativa de divisão por zero interceptada.");
        }
    }

    private static int Dividir(int dividendo, int divisor)
    {
        try
        {
            return dividendo / divisor;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}
