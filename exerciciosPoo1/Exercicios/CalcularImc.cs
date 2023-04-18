using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosPoo1.Exercicios;

internal class CalcularImc
{
    public static void Executar()
    {
        Console.WriteLine("Insira a altura em centimetros:");
        double x = int.Parse(Console.ReadLine());
        double altura = x / 100;

        Console.WriteLine("Insira o peso em kgs:");
        double peso = int.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        var classificacao = "";

        if (imc > 18.5)
        {
             classificacao = "magreza";
        }
        if (imc > 18.5 && imc < 24.9)
        {
             classificacao = "normal";
        }
        if (imc > 25 && imc < 29.9)
        {
             classificacao = "sobrepeso";
        }
        if (imc > 30 && imc < 39.9)
        {
             classificacao = "obesidade";
        }
        if (imc > 40)
        {
             classificacao = "Obesidade Grave";
        }



        Console.WriteLine($"Sua altura: {altura}, seu peso: {peso} kgs, seu imc: {imc}, classificação: {classificacao}");
    }
}
