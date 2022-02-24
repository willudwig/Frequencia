using System;

namespace Frequencia.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 8, 10, 8, 260, 4, 10, 10, 10, 5, 260 };

            int i = 0;
            int j = 0;
            int contador = 0;

            Array.Sort(numeros);

            while (i < numeros.Length)
            {
                while (j < numeros.Length)
                {
                    if (numeros[j] == numeros[i])
                    {
                        contador++;
                    }
                    j++;
                }
                Console.WriteLine("O número {0} aparece {1} vez(es)", numeros[i], contador);
                i += contador;
                j = i;
                contador = 0;
            }
            
            Console.ReadKey();
        }
    }
}
