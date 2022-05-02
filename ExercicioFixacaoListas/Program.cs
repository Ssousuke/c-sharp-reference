using System.Globalization;

namespace ExercicioFixacaoListas;

internal class Program
{
    private static void Main(string[] args)
    {
        var employee = new List<Employee>();

        Console.Write("Entre com a quantidade que quer adicionar: ");
        var quantity = int.Parse(Console.ReadLine());

        for (var i = 0; i < quantity; i++)
        {
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            var name = Console.ReadLine();
            Console.Write("Salário: ");
            var salary = double.Parse(Console.ReadLine());

            employee.Add(new Employee(id, name, salary));
        }

        Console.Write("Entre com o ID do funcionário que receberá aumento: ");
        var employeeId = int.Parse(Console.ReadLine());

        var emp = employee.Find(x => x.Id == employeeId);
        if (emp != null)
        {
            Console.Write("Entre com a porcentagem: ");
            var percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp.IncreaseSalary(percentage);
        }

        foreach (var item in employee) Console.WriteLine(item);
    }
}