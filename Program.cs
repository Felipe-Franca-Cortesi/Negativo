using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            double  numeroDigitado;
            string textoDigitado;
            bool numeroValido;

            Console.Clear();
            Console.WriteLine("--- Número Negativo\n");

            Console.Write("Digite um número: ");
            textoDigitado = Console.ReadLine();

            numeroValido = double.TryParse(textoDigitado, out numeroDigitado);
            
            if (!numeroValido)
            {
                Console.WriteLine("Por favor digite somente número(s) negativo(s)");
            }
            else if (numeroDigitado < 0)
            {
                Console.WriteLine("Você digitou um número negativo.");
            }
            
        }
    }
}
