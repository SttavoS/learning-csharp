using System;

class Program
{
    static void Main(string[] args)
    {
        double valorInvestido = 1500;
        double fatorRendimento = 1.0036;

        for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
        {
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= fatorRendimento;
                Console.WriteLine($"Ano: {contadorAno} | Mes: {contadorMes} | Valor R$ {valorInvestido.ToString("0.00")}");
            }
            fatorRendimento += 0.0010;
        }
    }
}