using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosPoo1.Exercicios;

internal class SomarNumeros
{
    public static void Executar()
    {
        Console.WriteLine("Insira o primeiro numero a ser somado:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o segundo numero a ser somado:");
        int y = int.Parse(Console.ReadLine());

        var sum = x + y;

        Console.WriteLine("Soma: " + sum);

    }
}
