using System;
using System.Collections.Generic;
using System.Globalization;
namespace ExercicioFixacaoListas
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();

            Console.Write("Entre com a quantidade que quer adicionar: ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine());

                employee.Add(new Employee(id, name, salary));
            }

            Console.Write("Entre com o ID do funcionário que receberá aumento: ");
            int employeeId = int.Parse(Console.ReadLine());

            Employee emp = employee.Find(x => x.Id == employeeId);
            if (emp != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }

            foreach (var item in employee)
            {
                Console.WriteLine(item);
            }
        }
    }
}

