using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosPoo1.Exercicios;

internal class MetersMilimeters
{
    public static void Executar()
    {
        Console.WriteLine("Insira o comprimento em metros, para ser transformado em milímetros :");
        int x = int.Parse(Console.ReadLine());

        int mili = x * 1000;

        Console.WriteLine($"Valor inserido em metros: {x}, em milimetros: {mili} mm");
    }
}
