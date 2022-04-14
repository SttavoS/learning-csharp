using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers1 = new int[] { 78, 56, 232, 12, 11, 43 };
        int[] numbers2 = new int[] { 78, 56, -2, 12, 8, -33 };
        int[] numbers3 = new int[] { 34, 15, 88, 2 };
        int[] numbers4 = new int[] { 34, -345, -1, 100 };

        Console.WriteLine(FindSmallestInt(numbers1));
        Console.WriteLine(FindSmallestInt(numbers2));
        Console.WriteLine(FindSmallestInt(numbers3));
        Console.WriteLine(FindSmallestInt(numbers4));
    }

    public static int FindSmallestInt(int[] args)
    {
        return args.Min<int>();
    }
}