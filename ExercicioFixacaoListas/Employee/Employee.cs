namespace ExercicioFixacaoListas;

public class Employee
{
    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; private set; }

    public void IncreaseSalary(double percentage)
    {
        Salary += Salary * percentage / 100;
    }

    public override string ToString()
    {
        return $"{Id}: {Name}, {Salary}";
    }
}