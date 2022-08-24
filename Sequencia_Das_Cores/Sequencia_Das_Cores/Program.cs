using System;

namespace Sequencia_das_Cores
{
    class Program
    {
        static void Main()
        {
            //Cores declaradas desodenadas
            var cores = new string[]
            {
                "Vermelho",
                "Azul",
                "Vermelho",
                "Vermelho",
                "Azul",
                "Vermelho",
                "Vermelho",
                "Azul",
                "Azul",
                "Azul"
            };

            //apresentação da cores de forma desordenada
            Console.WriteLine("Lista S de cores desordenada.\n");
            Console.WriteLine(String.Join(", ", cores));
            Console.WriteLine("\n");

            // Método Bubble Sort.
            for (int i = cores.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (cores[j] != "Azul")
                    {
                        string sequencia_i = cores[i];
                        cores[i] = cores[j];
                        cores[j] = sequencia_i;
                    }
                }
            }

            // Imprime sequência de cores ordenada.
            Console.WriteLine("Lista S de cores ordenada.\n");
            Console.WriteLine(String.Join(", ", cores));
            Console.WriteLine("\n");
            Console.WriteLine("Aperte qualquer tecla para sair\n");
            Console.ReadLine();
        }
    }

}
 