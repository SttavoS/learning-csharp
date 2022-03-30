using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(AreYouPlayingBanjo("Martin"));
        Console.WriteLine(AreYouPlayingBanjo("Rikke"));
        Console.WriteLine(AreYouPlayingBanjo("bravo"));
        Console.WriteLine(AreYouPlayingBanjo("rolf"));
    }

    public static string AreYouPlayingBanjo(string name)
    {
        char firstLetter = name.First<char>();
        if (firstLetter.Equals('R') || firstLetter.Equals('r'))
        {
            return $"{name} plays banjo";
        }
        else
        {
            return $"{name} does not play banjo";
        }
    }
}
