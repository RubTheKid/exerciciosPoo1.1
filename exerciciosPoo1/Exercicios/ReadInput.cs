namespace exerciciosPoo1.Exercicios;

internal class ReadInput
{
    public static void Executar()
    {
        bool isZero = false;

        while (isZero is false) 
        { 
            Console.WriteLine("insira um valor numérico de 1 a 9 ou insira 0 para sair");

            int input = Convert.ToInt32(Console.ReadLine());

            if (input != null)
            {
            
                if (input != 0)
                {
                    Console.WriteLine($"valor inserido: {input}");
                }
                if (input == 0)
                {
                        isZero = true;
                }
            }
        }
    }
}
