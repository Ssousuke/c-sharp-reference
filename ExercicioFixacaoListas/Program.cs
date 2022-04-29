using System;
using System.Collections.Generic;
namespace ExercicioFixacaoListas
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employe = new List<Employee>();

            int quantity = 3;

            for (int i = 0; i < quantity; i++)
            {
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                double salary = double.Parse(Console.ReadLine());

                employe.Add(new Employee(id, name, salary));
            }

            foreach (var item in employe)
            {
                Console.WriteLine(item);
            }
        }
    }
}

