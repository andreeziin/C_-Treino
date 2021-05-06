using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            char tipoCombustivel;
            double capacidadeTanque, precoCombustivel;

            Console.WriteLine("Programa Iniciado");

            Console.WriteLine("\nEscolha o tipo de combustivel Gasolina - (G) | Álcool (A).");
            tipoCombustivel = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite a capacidade do seu tanque: ");
            capacidadeTanque = double.Parse(Console.ReadLine());

            if (tipoCombustivel == 'G' || tipoCombustivel == 'g')
            {
                precoCombustivel = capacidadeTanque * 5.16;
                Console.WriteLine(@"{0} litros irá custar {1:C2}.
Programa Finalizado",capacidadeTanque, precoCombustivel);
            }
            else if (tipoCombustivel == 'A' || tipoCombustivel == 'a')
            {
                precoCombustivel = capacidadeTanque * 3.29;
                Console.WriteLine(@"{0} litros irá custar {1:C2}.
Programa Finalizado", capacidadeTanque, precoCombustivel);
            }
            else
            {
                Console.WriteLine($@"{tipoCombustivel} não é um tipo de combustível.");
            }
        }
    }
}
