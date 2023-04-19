namespace exerciciosPoo1.Exercicios;

internal class Financiamento
{
    public static void Executar()
    {
        Console.WriteLine("qual o valor do veículo?");
        double valorVeiculo = double.Parse(Console.ReadLine());

        Console.WriteLine("qual o valor da entrada?");
        double valorEntrada = double.Parse(Console.ReadLine());

        Console.WriteLine("quantas parcelas?");
        double qtdParcelas = double.Parse(Console.ReadLine());


        double juros = 3.5;

        double valorFinanciar = valorVeiculo - valorEntrada;

        double parcelaAntesJuros = valorFinanciar / qtdParcelas;

        double parcelaComJuros = parcelaAntesJuros + (parcelaAntesJuros * juros / 100);

        double valorAserPago = parcelaComJuros * qtdParcelas;

        Console.WriteLine($"Valor do veiculo: R${valorVeiculo}. Entrada: R$ {valorEntrada}, valor a financiar: R${valorFinanciar}.");
        Console.WriteLine($"Quantidade de Parcelas: {qtdParcelas}, taxa de juros A.M. : {juros}%.");
        Console.WriteLine($"valor de cada parcela: R$ {parcelaComJuros}. valor total a ser pago:  R$ {valorAserPago}");
    }
}
