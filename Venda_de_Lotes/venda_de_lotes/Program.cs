using System;
using System.Collections;


namespace Venda_De_Lotes
{
    //lista encadeada para armazenar uma entrada QUEUE.
    class Lista
    {
        public int x { get; set; }// quantidade de lotes pedidos.

        public int y { get; set; }// valor unitario dos lotes.

        public int id { get; set; }//registro do pedido.

        public string type { get; set; }//tipo de pedido.

        public Lista next;

    }

    //Classe que representa a QUEUE "adicionar um objeto ao final da fila"

    class Queue
    {
        public Lista PrimeiraPosicao { get; set; }

        //Adicionar ordens a Queue.
        #region Create
        public void Enqueue(Lista newLista)
        {
            if (PrimeiraPosicao == null)
            {
                PrimeiraPosicao = newLista;
            }
            else
            {
                var ultimaLista = GetUltimaLista();
                ultimaLista.next = newLista;
            }
        }

        private Lista GetUltimaLista()
        {
            var tempoLista = PrimeiraPosicao;
            while (tempoLista.next != null)
            {
                tempoLista = tempoLista.next;
            }
            return tempoLista;
        }
        #endregion
        //Retorna todos os pedidos adicionado na QUEUE.
        #region Read

        public List<Lista> GetListas()
        {
            var ordem = new List<Lista>();
            var tempoLista = PrimeiraPosicao;
            while (tempoLista != null)
            {
                ordem.Add(tempoLista);
                tempoLista = tempoLista.next;
            }
            return ordem;
        }
        #endregion

        //atualiza dados dos pedidos
        #region Atualizar_itens
        public void UpdateLista(Lista lista)
        {
            var tempoLista = PrimeiraPosicao;
            while (tempoLista != null)
            {
                if (lista.id == tempoLista.id)
                {
                    tempoLista.x = lista.x;

                    return;
                }
                tempoLista = tempoLista.next;
            }
        }
        #endregion

        //remover itens da lista
        #region Apagar_Itens

        public void DeQueue(int listaID)
        {
            var tempoLista = PrimeiraPosicao;
            if (PrimeiraPosicao.id == listaID)
            {
                PrimeiraPosicao = PrimeiraPosicao.next;
            }
            else
            {
                while (tempoLista != null)
                {
                    if (listaID == tempoLista.next.id)
                    {
                        tempoLista.next = tempoLista.next.next;
                        return;
                    }
                    tempoLista = tempoLista.next;
                }
            }
        }
        #endregion
    }
    // Principal entrada das variaveis
    class Program
    {
        static void Enqueue(Queue ordem)
        {
            int id;

            string type = "Comprar";
            Console.WriteLine("Quantidade de lotes que deseja comprar: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitario do lote: ");
            int y = int.Parse(Console.ReadLine());

            var lista = new Lista() { id = 0, type = type, x = x, y = y };

            ordem.Enqueue(lista);

        }

        public static void imprimirTodaLista(Queue ordem)
        {
            Console.WriteLine($"Lista de lotes que permanecem compradas.");
            foreach (var item in ordem.GetListas())
            {
                Console.WriteLine($"ID {item.id} - Tipo {item.type} - Lotes {item.x} - Valor R$ {item.y}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int option;
            var ordem = new Queue();

            do
            {
                //Menu de opções
                Console.WriteLine("Menu : ");
                Console.WriteLine("1 - Comprar Lote");
                Console.WriteLine("2 - Vender lote");
                Console.WriteLine("3 - Extrato");
                Console.WriteLine("4 - Finalizar Operação");

                //entrada da opção selecionada
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Enqueue(ordem);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Vender Lote!");
                }
                else if (option == 3)
                {
                    Console.WriteLine("Extrato da operação.");
                   
                    imprimirTodaLista(ordem);
                }
                else if (option == 4)
                {
                    Console.WriteLine("Encerrar operação");
                }
                else if (option != 1 || option != 2 || option != 3 || option != 4)
                {
                    Console.WriteLine("Opção Invalida. Escolha a opção indicada no Menu.");
                }

            }
            while (option != 4);            
            }
    }
}

