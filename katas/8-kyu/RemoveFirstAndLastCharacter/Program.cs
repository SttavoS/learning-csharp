public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RemoveChars("eloquent"));
        Console.WriteLine(RemoveChars("country"));
        Console.WriteLine(RemoveChars("person"));
        Console.WriteLine(RemoveChars("place"));
        Console.WriteLine(RemoveChars("ok"));
    }

    private static string RemoveChars(string input)
    {
        var lastChar = input.Length - 1;
        return input.Remove(lastChar, 1).Remove(0, 1);
    }
}
