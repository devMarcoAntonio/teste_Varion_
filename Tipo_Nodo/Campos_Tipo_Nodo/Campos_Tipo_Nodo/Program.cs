using System;

namespace Campos_Tipo_Nodo
{
    //Estruturando os Campos de tipo Nodo.
    public class Nodo
    {
        public int data;
        public Nodo next;
        public Nodo(int numero)
        {
            data = numero;
            next = null;
        }
    }

    // Lista Encadeada dos Nodos
    public class LinkedList
    {
        Nodo head; // Head da lista

        // Insere um novo nodo na frente da lista
        public void push(int newData)
        {
            // Aloca o novo nodo e inclui os dados
            Nodo newNodo = new Nodo(newData);

            // Torna o novo nodo em head
            newNodo.next = head;

            // Move o head para apontar para o novo Nodo
            head = newNodo;
        }

        // Verifica se a chave de 1 ao 10 se está presente na lista encadeada
        public bool search(Nodo head, int chave)
        {
            Nodo current = head;
            while (current != null)
            {
                if (current.data == chave)
                    return true; // Elemento boolean encontrado
                current = current.next;
            }
            return false; // Elemento boolean não encontrado
        }

        //Principal
        public static void Main(String[] args)
        {

            //Inicia com uma nova Lista vazia
            LinkedList list = new LinkedList();

            //Use push() para adicionar itens a lista
            list.push(1);
            list.push(2);
            list.push(3);
            list.push(4);
            list.push(5);
            list.push(6);
            list.push(7);
            list.push(8);
            list.push(9);
            list.push(10);

            //Verifica se a chave pertence a lista.
            Console.WriteLine("Qual chave você deseja verificar?");
            int chave = int.Parse(Console.ReadLine());

            if (list.search(list.head, chave))
                Console.WriteLine("A chave pertence a lista.");
            else
                Console.WriteLine("A chave não pertence a lista.");
        }
    }
}

