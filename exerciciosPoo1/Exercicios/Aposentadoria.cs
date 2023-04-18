using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosPoo1.Exercicios;

internal class Aposentadoria
{
    public static void Executar()
    {
        Console.WriteLine("homem ou mulher?");
        string s = Console.ReadLine();
        int aposenta = 0;
   

        if (s == "homem")
        {
            
            aposenta = 35;
        } 
        if (s == "mulher")
        {
           
            aposenta = 30;
        }

        Console.WriteLine("idade?");
        int i = int.Parse(Console.ReadLine());


        Console.WriteLine("qual o tempo de contribuição?");
        int c = int.Parse(Console.ReadLine());

        int tempoContribuicao = aposenta - c;

        Console.WriteLine($"para aposentar por tempo de contribuição, você tem que completar mais {tempoContribuicao} anos de contribuição");
        Console.WriteLine($"ou seja, você vai aposentar com 100% da aposentadoria só com {i+tempoContribuicao} anos de idade.");


    }
}
