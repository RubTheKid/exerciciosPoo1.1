using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosPoo1.Exercicios;

internal class Adivinhar
{
    public static void Executar()
    {
        Console.WriteLine("Vou tentar adivinhar o número entre 1 e 10 que você está pensando...responda com sim ou não");

        Console.WriteLine("É par?");
        var x = Console.ReadLine();

        if (x == "sim")
        {
            Console.WriteLine("é divisivel por 3?");
            var a = Console.ReadLine();

            if(a == "sim")
            {
                Console.WriteLine("o numero é 6.");
            }
            if(a == "nao")
            {
                Console.WriteLine("divisivel por 5?");
                var s = Console.ReadLine();

                if (s == "sim")
                {
                    Console.WriteLine("o numero é 10");
                }
                if (s == "nao")
                {
                    Console.WriteLine("divisivel por 4?");
                    var e = Console.ReadLine();
                    if (e == "sim")
                    {
                        Console.WriteLine("ou é 4 ou 8, se contente com isso");
                    }
                }
            }
        }
        if (x == "não")
        {
            Console.WriteLine("ou é 1,3,5,7 ou 9. ié ié");
        }
    }
}
