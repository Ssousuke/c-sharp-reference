using System.Globalization;
using Vetores.Exercice.entity;

namespace Vetores;

public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var product = new Product[n];

        for (var i = 0; i < n; i++)
        {
            var name = Console.ReadLine();
            var price = double.Parse(Console.ReadLine());

            product[i] = new Product { Name = name, Price = price };
        }

        var sum = 0.0;
        foreach (var i in product) sum += i.Price;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {(sum / n).ToString("F2", CultureInfo.CurrentCulture)}");
    }
}