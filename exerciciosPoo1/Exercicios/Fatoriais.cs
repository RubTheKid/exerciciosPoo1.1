using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosPoo1.Exercicios;

internal class Fatoriais
{
    public static void Executar()
    {
        for (int i = 0; i < 10; i++)
        {
            int x = 1;
            for (int j = 0; j < 10; j++)
            {
                x *= j;
            }
            Console.WriteLine($"O fatorial de {i} é {x} ");
        }
    }
}