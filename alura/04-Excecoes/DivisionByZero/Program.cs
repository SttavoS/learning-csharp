public class Program
{
    static void Main(string[] args)
    {
        try
        {
            int number = 10;
            int zero = 0;

            int divisao = number / zero;

            Console.WriteLine(divisao);
        }
        catch (DivideByZeroException)
        {

            Console.WriteLine("Tentativa de divisão por zero interceptada.");
        }
    }
}
