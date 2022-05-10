public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(NoSpaces("8 j 8   mBliB8g  imjB8B8  jl  "));
        Console.WriteLine(NoSpaces("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));
        Console.WriteLine(NoSpaces("8aaaaa dddd r     "));
    }

    private static string NoSpaces(string input)
        => input.Trim().Replace(" ", "");
}