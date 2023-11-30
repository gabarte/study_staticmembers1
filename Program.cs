using estudo_membrosestaticos1;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual a cotação do dólar? ");
        double cotacao = double.Parse(Console.ReadLine());

        Console.Write("Quantos dólares você vai comprar? ");
        double quantia = double.Parse(Console.ReadLine());

        double result = ConversorDeMoeda.DolarParaReal(cotacao, quantia);

        Console.WriteLine("O valor à ser pago em real é: R$" + result.ToString("F2"));
    }
}