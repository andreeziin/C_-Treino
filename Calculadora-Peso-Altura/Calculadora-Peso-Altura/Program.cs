using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Peso_Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            char escolha;
            double altura, pesoIdeal;

            Console.WriteLine("Escolha seu sexo (M)|(F)");
            escolha = char.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            if (escolha == 'M' || escolha == 'm')
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($@"Seu peso ideal é {pesoIdeal.ToString("N2")}
Programa Finalizado");
            }
            else if (escolha == 'F' || escolha == 'f')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine($@"Seu peso ideal é {pesoIdeal.ToString("N2")}
Programa Finalizado");
            }
            else
            {
                Console.WriteLine($"{altura} não é um sexo válido.");
            }
        }
    }
}
