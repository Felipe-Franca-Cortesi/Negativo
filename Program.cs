using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- Número Negativo\n");

            Console.Write("Digite um número: ");
            double  numeroDigitado = Convert.ToDouble(Console.ReadLine());

            if (numeroDigitado < 0)
            {
                Console.WriteLine("Você digitou um número negativo.");
            }
            
        }
    }
}
