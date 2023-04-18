using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosPoo1.Exercicios;

internal class ImpostoRenda
{
    public static void Executar()
    {
        Console.WriteLine("Informe o salário: ");
        double sal = double.Parse(Console.ReadLine());

        double aliquota = 0;
        double irpf = 0;
        bool salBaixo = false;

        if (sal >= 1903.98)
        {
            aliquota = 0;
            irpf = 0;
            salBaixo = true;
        }
        if (sal >= 1903.99 && sal <= 2826.65)
        {
            aliquota = 7.5;
            irpf = 142.80;
        }
        if (sal >= 2826.66 && sal <= 3751.05)
        {
            aliquota = 15;
            irpf = 354.80;
        }
        if (sal >= 3751.06 && sal <= 4664.68)
        {
            aliquota = 22.5;
            irpf = 636.13;
        }
        if (sal >= 4664.69)
        {
            aliquota = 27.5;
            irpf = 869.36;
        }



        double calcAli = sal * (aliquota / 100);

        double salarioFinal = sal - calcAli - irpf;

        if (!salBaixo)
        {
            Console.WriteLine($"Salário: {sal}. Não há desconto de IR.");
        }
        else 
        { 
            Console.WriteLine($"Aliquota: {aliquota}% no valor de : R${calcAli}. Valor a deduzir do IRPF: R${irpf}. Salario final após o roubo: R$ {salarioFinal}");
        }
    }
}
