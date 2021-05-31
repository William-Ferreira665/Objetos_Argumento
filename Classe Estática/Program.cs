using System;
using Classe_Estática.Classes;

namespace Classe_Estática
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para conversão de moedas.");

            Console.WriteLine("Digite o valor em R$:");
            float valorEmReais = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em Dólares: ");
            float valorDolar = float.Parse(Console.ReadLine());

            Console.WriteLine("O valor convertido em Dólar é de: ");
            Console.WriteLine(Conversor.RealDolar(valorEmReais));

            Console.WriteLine("O valor convertido em R$ é de: ");
            Console.WriteLine(Conversor.DolarReal(valorDolar)); 
        }
    }
}
