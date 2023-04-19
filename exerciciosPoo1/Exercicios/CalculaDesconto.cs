namespace exerciciosPoo1.Exercicios;

internal class CalculaDesconto
{
    public static void Executar()
    {
        Console.WriteLine("Insira o valor do salário:");
        double x = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o valor do Desconto:");
        int y = int.Parse(Console.ReadLine());

        double desconto = y * 0.01;

        double salario = x - (x * desconto);

        Console.WriteLine($"salario anterior: R$ {x} . Salario corrigido com desconto: R$ {salario}");
    }
}
