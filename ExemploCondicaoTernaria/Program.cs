using System;
using System.Globalization;

namespace ExemploCondicaoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //if-else tradicional
            /*
            double desconto;

            if(preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            */

            //Expressão Condicional Ternária
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05; //se preco menor que 20, 10% de desconto, senão 5%.

            Console.WriteLine("Desconto: " + desconto);
        }
    }
}
