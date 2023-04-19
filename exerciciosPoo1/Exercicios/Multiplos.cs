namespace exerciciosPoo1.Exercicios;

internal class Multiplos
{
    public static void Executar()
    {
        Console.WriteLine("pressione qualquer tecla para exibir os multiplos de 3 entre 0 e 100...");
        Console.ReadLine();

        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
