using exerciciosPoo1;
using exerciciosPoo1.Exercicios;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new SelecionarExercicio(new Dictionary<string, Action>() {
                {"Primeiro Programa - Ler input", ReadInput.Executar},
                {"Somar Numeros", SomarNumeros.Executar},
                {"Converter metros para milimetros", MetersMilimeters.Executar },
                {"Calcular aumento", CalculaAumento.Executar },
                {"Calcular desconto", CalculaDesconto.Executar },
                {"Calcular IMC", CalcularImc.Executar },
                {"Contar até numero fornecido", ContarAteNumero.Executar },
                {"Tabuada", Tabuada.Executar }, 
                {"Multiplos de 3 entre 0 e 100", Multiplos.Executar }, 
                {"Fatoriais de 1 a 10", Fatoriais.Executar }, 
                {"Calculo de Imposto de Renda", ImpostoRenda.Executar }, 
                {"Adivinhador 3000 plus", Adivinhar.Executar }, 
                {"Financiamento de veículo", Financiamento.Executar }, 
                {"Calculadora de Aposentadoria", Aposentadoria.Executar }, 
                {"Jogo da Velha", JogoDaVelha.Executar }, 
            });

            central.SelecionarEExecutar();
        }
    }
}