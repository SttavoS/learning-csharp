using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(NumberToString(67));
        Console.WriteLine(NumberToString(79585));
        Console.WriteLine(NumberToString(1 + 2));
        Console.WriteLine(NumberToString(1 - 2));
    }

    public static string NumberToString(int number) 
    {
        return number.ToString();
    }
}