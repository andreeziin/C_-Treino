using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, ajuste;

            Console.WriteLine("\nPrograma Iniciado");

            Console.Write("\nDigite o sálario do funcionário para o novo ajuste: ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 500)
            {
                ajuste = salario * 1.15;
                Console.WriteLine($"\nO novo ajuste do salário {salario:C2} de 15% foi para {ajuste:C2}.");

                Console.WriteLine("\nPrograma Finalizado.");
            }
            else if (salario >= 500 && salario <=1000)
            {
                ajuste = salario * 1.10;
                Console.WriteLine($"\nO novo ajuste do salário {salario:C2} de 10% foi para {ajuste:C2}.");

                Console.WriteLine($"\nPrograma Finalizdo.");
            }
            else
            {
                ajuste = salario * 1.05;
                Console.WriteLine($"\nO novo ajuste do salário {salario:C2} de 5% foi para {ajuste:C2}.");
            }
        }
    }
}
