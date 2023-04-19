using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosPoo1.Exercicios;

internal class ContarAteNumero
{
    public static void Executar()
    { 
        Console.WriteLine("Insira o numero para a contagem: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 0; i <= numero; i++)
        {
            Console.WriteLine(i);
           
        }
    }
}
