using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosPoo1.Exercicios
{
    internal class CalculaAumento
    {
        public static void Executar()
        {
            Console.WriteLine("Insira o valor do salário:");
            double x = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do aumento:");
            int y = int.Parse(Console.ReadLine());

            double aumento = y * 0.01;

            double salario = x + (x * aumento);

            Console.WriteLine($"salario anterior: R$ {x} . Salario corrigido com aumento: R$ {salario}");
        }
    }
}
