public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SringToNumber("1234"));
        Console.WriteLine(SringToNumber("605"));
        Console.WriteLine(SringToNumber("1405"));
        Console.WriteLine(SringToNumber("-7"));
    }

    private static int SringToNumber(string input)
        => Int32.Parse(input);
}