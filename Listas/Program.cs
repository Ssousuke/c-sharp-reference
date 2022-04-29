using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando uma lista
            List<string> list = new List<string>();

            // Adicionando dados de forma sequencial
            list.Add("Mariano");
            list.Add("Maria");
            list.Add("Marcos");
            list.Add("Matheus");
            list.Add("Wesley");
            list.Add("João");
            list.Add("Lucas");

            // Inserindo
            // A função Insert recebe a posição e o valor a ser inserido
            list.Insert(0, "Ana");
            list.Insert(7, "Zeca");
            foreach (var item in list)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine($"Total: {list.Count}");

            // Buscar a primeira pessoa por letra
            string first = list.Find(x => x[0] == 'M');
            Console.WriteLine($"Primeiro nome com a letra M: {first}");

            // Bucas a última pessoa por letra
            string last = list.FindLast(x => x[0] == 'M');
            Console.WriteLine($"Último nome com a letra M: {last}");

            // Buscando a posição do primeiro item que começa com a letra
            int pos1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine($"Primeira posição com a letra 'M': {pos1}");

            // Buscando a última posição do item que começa com a letra
            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine($"Última posição com a letra 'M': {pos2}");

            // Removendo o item pelo valor
            list.Remove("Zeca");
            Console.WriteLine("Remove Zeca:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Remove todos os itens que começam com a letra
            Console.WriteLine("Remove todos os nomes que começam com M: ");
            list.RemoveAll(x => x[0] == 'M');
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}