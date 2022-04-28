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
            Console.WriteLine($"Primeiro nome com a letra A: {first}");
        }
    }
}