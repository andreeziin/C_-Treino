using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_LetrasIguais
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUm, numeroDois, soma, subtracao;

            Console.WriteLine("Programa Iniciado.");

            Console.WriteLine("\nDigite dois números iguais ou diferentes.");

            Console.Write("\nDigite o número um: ");
            numeroUm = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o número dois: ");
            numeroDois = double.Parse(Console.ReadLine());

            if (numeroUm == numeroDois)
            {
                soma = numeroUm + numeroDois;
                Console.WriteLine($"\nA soma dos dois números iguais é: {soma}.");

                Console.WriteLine("\nPrograma Finalizado");
            }
            else if(numeroUm != numeroDois)
            {
                subtracao = numeroUm - numeroDois;
                Console.WriteLine($"\nA subtração dos números diferentes é: {subtracao}.");

                Console.WriteLine("\nPrograma Finalizado.");
            }
        }
    }
}
