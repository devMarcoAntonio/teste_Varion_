using System;

namespace Sequencia_Objetos_Inteiros
{
    static class Program
    {
        //Criando uma array de s com numeros inteiros(objetos).
        static int[] s = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Implementando um método recursivo para verificar se um elemento k pertence a uma sequência s.
        static int verificador(int[] s, int l, int r, int k)
        {
            if (r < 1)
            {
                return -1;
            }
            if (s[1] == k)
            {
                return 1;
            }
            if (s[r] == k)
            {
                return r;
            }
            return verificador(s, 1 + 1, r - 1, k);
        }

        public static void Main(String[] args)
        {
            // O número a ser verificado dentro da sequencia s.
            Console.WriteLine("Qual número você gostaria de verificar dentro da sequência s?");
            string[] lista = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            Console.WriteLine(String.Join(",", lista));
            int k = int.Parse(Console.ReadLine());

            //Método para verificar se o elemento k pertence a sequencia s.
            int indice = verificador(s, 0, s.Length - 1, k);

            if (indice != -1 || indice > 10)
            {
                Console.WriteLine("O Elemento " + k + " está presente na Sequência s.\n");
            }
            else
            {
                Console.WriteLine("O Elemento " + k + " não está presente na Sequência s.\n");
            }
            Console.WriteLine("Aperte qualquer tecla para sair.");
            Console.Read();

        }
    }
}

