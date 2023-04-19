namespace exerciciosPoo1.Exercicios;

internal class Tabuada
{
    public static void Executar()
    {
        Console.WriteLine("Insira o numero para a contagem: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");

        }
    }
}
