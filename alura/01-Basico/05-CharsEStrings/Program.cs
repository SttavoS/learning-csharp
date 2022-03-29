using System;

class Program
{
    static void Main(string[] args)
    {
        char letra = 'a';
        System.Console.WriteLine(letra);

        char valorDaTabelaAscii = (char)65;
        Console.WriteLine(valorDaTabelaAscii);

        valorDaTabelaAscii = (char) (valorDaTabelaAscii + 1);
        Console.WriteLine(valorDaTabelaAscii);
    }
}